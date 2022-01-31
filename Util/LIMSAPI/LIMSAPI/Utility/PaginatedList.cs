using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LIMSAPI.Utility
{
    public class PaginatedList<T>
    {
        public List<T> GetData(IQueryable<T> dataResult, PagingParameters pagingInputModel)
        {
            try
            {
                int CurrentPage; int PageSize;

                // Return List of data  
                var source = dataResult.AsQueryable();

                // Get's No of Rows Count   
                int count = source.Count();

                // Parameter is passed from Query string if it is null then it default Value will be pageNumber:1 
                // Only a FromUri attribute used on method passing object is null then default value will be pageNumber:1 
                if (pagingInputModel == null)
                {
                    CurrentPage = 1;
                }
                else
                {
                    CurrentPage = pagingInputModel.pageNumber;
                }

                // Parameter is passed from Query string if it is null then it default Value will be pageSize:10
                // Only a FromUri attribute used on method passing object is null then default value will be pageSize:10
                if (pagingInputModel == null)
                {
                    PageSize = 10;
                }
                else
                {
                    PageSize = pagingInputModel.pageSize;
                }

                // Display TotalCount to Records to User  
                int TotalCount = count;

                // Calculating Totalpage by Dividing (No of Records / Pagesize)  
                int TotalPages = (int)Math.Ceiling(count / (double)PageSize);

                // Returns List of Data after applying Paging   
                var items = source.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();

                // if CurrentPage is greater than 1 means it has previousPage  
                var previousPage = CurrentPage > 1 ? "Yes" : "No";

                // if TotalPages is greater than CurrentPage means it has nextPage  
                var nextPage = CurrentPage < TotalPages ? "Yes" : "No";

                // Object which we are going to send in header   
                var paginationMetadata = new
                {
                    totalCount = TotalCount,
                    pageSize = PageSize,
                    currentPage = CurrentPage,
                    totalPages = TotalPages,
                    previousPage,
                    nextPage
                };

                // Setting Header  
                HttpContext.Current.Response.Headers.Add("Paging-Headers", JsonConvert.SerializeObject(paginationMetadata));

                // Returing List of data Collections  
                return items;
            }
            catch (Exception ex)
            {
               throw ex;
            }
        }
    }
}