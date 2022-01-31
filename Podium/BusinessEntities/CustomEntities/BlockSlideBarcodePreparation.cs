using System;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
    public class BlockSlideBarcodePreparation
    {
        string _strTissue = string.Empty;
        string _BlockBarCode = string.Empty;
        string _BlockType = string.Empty;
        string _SlideBarcode = string.Empty;
        string _slideName = string.Empty;
        string _SlideComments = string.Empty;
        string _stainType = string.Empty;
        string _Type = string.Empty;
        string _barcode = string.Empty;
        string _histoNumber = string.Empty;

        public string HistoNumber
        {
            get { return _histoNumber; }
            set { _histoNumber = value; }
        }
        public string StainType
        {
            get { return _stainType; }
            set { _stainType = value; }
        }
        public string SlideComments
        {
            get { return _SlideComments; }
            set { _SlideComments = value; }
        }

        public string BlockType
        {
            get { return _BlockType; }
            set { _BlockType = value; }
        }
        public string BarCode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }
        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
        public string Tissue
        {
            get { return _strTissue; }
            set { _strTissue = value; }
        }
        public string BlockBarCode
        {
            get { return _BlockBarCode; }
            set { _BlockBarCode = value; }
        }
        public string SlideBarCode
        {
            get { return _SlideBarcode; }
            set { _SlideBarcode = value; }
        }
        public string SlideName
        {
            get { return _slideName; }
            set { _slideName = value; }
        }
    }
}
