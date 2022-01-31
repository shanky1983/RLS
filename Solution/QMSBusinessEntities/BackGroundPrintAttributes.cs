using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Attune.Solution.QMSBusinessEntities
{
	public class BackGroundPrintAttributes
	{
		#region Fields

		private long backGroundPrintAttributesID=0;
		private long backGroundPrintContentID=0;
		private string fontName=String.Empty;
		private string fontStyle=String.Empty;
		private string fontColor=String.Empty;
		private byte fontSize=0x00;
		private decimal xAxis=Decimal.Zero;
		private decimal yAxis=Decimal.Zero;
		private decimal width=Decimal.Zero;
		private decimal hight=Decimal.Zero;
		private bool status=false;

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the BackGroundPrintAttributesID value.
		/// </summary>
		public long BackGroundPrintAttributesID
		{
			get { return backGroundPrintAttributesID; }
			set { backGroundPrintAttributesID = value; }
		}

		/// <summary>
		/// Gets or sets the BackGroundPrintContentID value.
		/// </summary>
		public long BackGroundPrintContentID
		{
			get { return backGroundPrintContentID; }
			set { backGroundPrintContentID = value; }
		}

		/// <summary>
		/// Gets or sets the FontName value.
		/// </summary>
		public string FontName
		{
			get { return fontName; }
			set { fontName = value; }
		}

		/// <summary>
		/// Gets or sets the FontStyle value.
		/// </summary>
		public string FontStyle
		{
			get { return fontStyle; }
			set { fontStyle = value; }
		}

		/// <summary>
		/// Gets or sets the FontColor value.
		/// </summary>
		public string FontColor
		{
			get { return fontColor; }
			set { fontColor = value; }
		}

		/// <summary>
		/// Gets or sets the FontSize value.
		/// </summary>
		public byte FontSize
		{
			get { return fontSize; }
			set { fontSize = value; }
		}

		/// <summary>
		/// Gets or sets the XAxis value.
		/// </summary>
		public decimal XAxis
		{
			get { return xAxis; }
			set { xAxis = value; }
		}

		/// <summary>
		/// Gets or sets the YAxis value.
		/// </summary>
		public decimal YAxis
		{
			get { return yAxis; }
			set { yAxis = value; }
		}

		/// <summary>
		/// Gets or sets the Width value.
		/// </summary>
		public decimal Width
		{
			get { return width; }
			set { width = value; }
		}

		/// <summary>
		/// Gets or sets the Hight value.
		/// </summary>
		public decimal Hight
		{
			get { return hight; }
			set { hight = value; }
		}

		/// <summary>
		/// Gets or sets the Status value.
		/// </summary>
		public bool Status
		{
			get { return status; }
			set { status = value; }
		}


		#endregion
}
}
