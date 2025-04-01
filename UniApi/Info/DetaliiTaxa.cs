using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace UniApi.Info
{

	[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = false)]
	[XmlRootAttribute("root", Namespace = "", IsNullable = false, DataType = "string")]
	//ElementName = elementul din coloana din BD
	[Serializable()]
	public partial class DetaliiTaxaXML
	{
		/// <remarks/>

		private long id_detaliuplansemestruField;

		private long id_notaField;

		private string platitField;

		private int a_cata_prezentare_in_afara_anului_materieiField;

		private string data_hotarariiField;

		/// <remarks/>
		[System.Xml.Serialization.XmlElement()]
		public long id_detaliuplansemestru
		{
			get
			{
				return this.id_detaliuplansemestruField;
			}
			set
			{
				this.id_detaliuplansemestruField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElement()]
		public long id_nota
		{
			get
			{
				return this.id_notaField;
			}
			set
			{
				this.id_notaField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElement()]
		public string platit
		{
			get
			{
				return this.platitField;
			}
			set
			{
				this.platitField = value;
			}
		}

		/// <remarks/>
		[System.Xml.Serialization.XmlElement()]
		public int a_cata_prezentare_in_afara_anului_materiei
		{
			get
			{
				return this.a_cata_prezentare_in_afara_anului_materieiField;
			}
			set
			{
				this.a_cata_prezentare_in_afara_anului_materieiField = value;
			}
		}

		[System.Xml.Serialization.XmlElement()]
		public string data_hotararii
		{
			get
			{
				return this.data_hotarariiField;
			}
			set
			{
				this.data_hotarariiField = value;
			}
		}

	}

}