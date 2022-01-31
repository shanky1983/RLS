using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Podium.BusinessEntities
{
	public class Patient_Info
	{
		#region Fields

		private short database_id=0;
		private int object_id=0;
		private int index_id=0;
		private int partition_number=0;
		private string index_type_desc=String.Empty;
		private string alloc_unit_type_desc=String.Empty;
		private byte index_depth=0x00;
		private byte index_level=0x00;
		private float avg_fragmentation_in_percent=0.0F;
		private long fragment_count=0;
		private float avg_fragment_size_in_pages=0.0F;
		private long page_count=0;
		private float avg_page_space_used_in_percent=0.0F;
		private long record_count=0;
		private long ghost_record_count=0;
		private long version_ghost_record_count=0;
		private int min_record_size_in_bytes=0;
		private int max_record_size_in_bytes=0;
		private float avg_record_size_in_bytes=0.0F;
		private long forwarded_record_count=0;
		private long compressed_page_count=0;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Database_id value.
		/// </summary>
		public short Database_id
		{
			get { return database_id; }
			set { database_id = value; }
		}

		/// <summary>
		/// Gets or sets the Object_id value.
		/// </summary>
		public int Object_id
		{
			get { return object_id; }
			set { object_id = value; }
		}

		/// <summary>
		/// Gets or sets the Index_id value.
		/// </summary>
		public int Index_id
		{
			get { return index_id; }
			set { index_id = value; }
		}

		/// <summary>
		/// Gets or sets the Partition_number value.
		/// </summary>
		public int Partition_number
		{
			get { return partition_number; }
			set { partition_number = value; }
		}

		/// <summary>
		/// Gets or sets the Index_type_desc value.
		/// </summary>
		public string Index_type_desc
		{
			get { return index_type_desc; }
			set { index_type_desc = value; }
		}

		/// <summary>
		/// Gets or sets the Alloc_unit_type_desc value.
		/// </summary>
		public string Alloc_unit_type_desc
		{
			get { return alloc_unit_type_desc; }
			set { alloc_unit_type_desc = value; }
		}

		/// <summary>
		/// Gets or sets the Index_depth value.
		/// </summary>
		public byte Index_depth
		{
			get { return index_depth; }
			set { index_depth = value; }
		}

		/// <summary>
		/// Gets or sets the Index_level value.
		/// </summary>
		public byte Index_level
		{
			get { return index_level; }
			set { index_level = value; }
		}

		/// <summary>
		/// Gets or sets the Avg_fragmentation_in_percent value.
		/// </summary>
		public float Avg_fragmentation_in_percent
		{
			get { return avg_fragmentation_in_percent; }
			set { avg_fragmentation_in_percent = value; }
		}

		/// <summary>
		/// Gets or sets the Fragment_count value.
		/// </summary>
		public long Fragment_count
		{
			get { return fragment_count; }
			set { fragment_count = value; }
		}

		/// <summary>
		/// Gets or sets the Avg_fragment_size_in_pages value.
		/// </summary>
		public float Avg_fragment_size_in_pages
		{
			get { return avg_fragment_size_in_pages; }
			set { avg_fragment_size_in_pages = value; }
		}

		/// <summary>
		/// Gets or sets the Page_count value.
		/// </summary>
		public long Page_count
		{
			get { return page_count; }
			set { page_count = value; }
		}

		/// <summary>
		/// Gets or sets the Avg_page_space_used_in_percent value.
		/// </summary>
		public float Avg_page_space_used_in_percent
		{
			get { return avg_page_space_used_in_percent; }
			set { avg_page_space_used_in_percent = value; }
		}

		/// <summary>
		/// Gets or sets the Record_count value.
		/// </summary>
		public long Record_count
		{
			get { return record_count; }
			set { record_count = value; }
		}

		/// <summary>
		/// Gets or sets the Ghost_record_count value.
		/// </summary>
		public long Ghost_record_count
		{
			get { return ghost_record_count; }
			set { ghost_record_count = value; }
		}

		/// <summary>
		/// Gets or sets the Version_ghost_record_count value.
		/// </summary>
		public long Version_ghost_record_count
		{
			get { return version_ghost_record_count; }
			set { version_ghost_record_count = value; }
		}

		/// <summary>
		/// Gets or sets the Min_record_size_in_bytes value.
		/// </summary>
		public int Min_record_size_in_bytes
		{
			get { return min_record_size_in_bytes; }
			set { min_record_size_in_bytes = value; }
		}

		/// <summary>
		/// Gets or sets the Max_record_size_in_bytes value.
		/// </summary>
		public int Max_record_size_in_bytes
		{
			get { return max_record_size_in_bytes; }
			set { max_record_size_in_bytes = value; }
		}

		/// <summary>
		/// Gets or sets the Avg_record_size_in_bytes value.
		/// </summary>
		public float Avg_record_size_in_bytes
		{
			get { return avg_record_size_in_bytes; }
			set { avg_record_size_in_bytes = value; }
		}

		/// <summary>
		/// Gets or sets the Forwarded_record_count value.
		/// </summary>
		public long Forwarded_record_count
		{
			get { return forwarded_record_count; }
			set { forwarded_record_count = value; }
		}

		/// <summary>
		/// Gets or sets the Compressed_page_count value.
		/// </summary>
		public long Compressed_page_count
		{
			get { return compressed_page_count; }
			set { compressed_page_count = value; }
		}


		#endregion
}
}
