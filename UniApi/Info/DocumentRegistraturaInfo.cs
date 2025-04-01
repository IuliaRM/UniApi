using System;
using System.Collections.Generic;
namespace UniApi.Info
{
    public class DocumentRegistraturaInfo
    {
        long _iD_DocReg;
        string _nrInregistrareDoc;
        string _descriereDoc;
        DateTime _dataInregistrare;
        string _autor;
        string _cOD_SEC;

        public DocumentRegistraturaInfo()
        {
        }

        public DocumentRegistraturaInfo(dynamic document)
        {
            if (document != null)
            {
                //ciudatenii, deoarece in BD se pare ca pot aparea numere de tip double DataInregistrare=1.418921685024E12 ---> 1418921685024
                string strDataInregistrare = document.DataInregistrare.ToString();
                if (strDataInregistrare.Contains(".") || strDataInregistrare.Contains("E"))
                {
                    strDataInregistrare = strDataInregistrare.Replace(".", "").Replace("E", "");
                }

                long val = long.Parse(strDataInregistrare);
                DateTime data = new DateTime(val);

                this.NrInregistrareDoc = document.NrInregistrare.ToString();
                this.DescriereDoc = document.DescriereDoc.ToString();
                this.DataInregistrare = data;
                this.Autor = document.Autor.ToString();
                this.DEN_SEC = document.DEN_SEC.ToString();
                this.COD_SEC = document.COD_SEC.ToString();
                this.TipIO = document.TipIO.ToString();
                this.An = int.Parse(document.An.ToString());
                this.DocumentId = document.Id;

                if (document.TipDocInternExtern != null)
                {
                    this.TipDocInternExtern = int.Parse(document.TipDocInternExtern.ToString());
                }

                if (document.NrInregistrareExterior != null)
                {
                    this.NrInregistrareExterior = document.NrInregistrareExterior.ToString();
                }

                if (document.PredatFizic != null)
                {
                    this.PredatFizic = bool.Parse(document.PredatFizic.ToString());
                }

                //this.Flux = new List<FluxDocRegInfo>();
                if (document.flux != null)
                {
                    //this.Flux = gson.fromJson(document.getProperty("flux").ToString(), listType);
                }
            }
        }



        public DocumentRegistraturaInfo(long iD_DocReg, string nrInregistrareDoc, string descriereDoc, DateTime dataInregistrare, string autor, string cOD_SEC)
        {
            this.ID_DocReg = iD_DocReg;
            this.NrInregistrareDoc = nrInregistrareDoc;
            this.DescriereDoc = descriereDoc;
            this.DataInregistrare = dataInregistrare;
            this.Autor = autor;
            this.COD_SEC = cOD_SEC;
        }

        public long ID_DocReg
        {
            get { return _iD_DocReg; }
            set { _iD_DocReg = value; }
        }

        public string NrInregistrareDoc
        {
            get { return _nrInregistrareDoc; }
            set { _nrInregistrareDoc = value; }
        }

        public string DescriereDoc
        {
            get { return _descriereDoc; }
            set { _descriereDoc = value; }
        }

        public DateTime DataInregistrare
        {
            get { return _dataInregistrare; }
            set { _dataInregistrare = value; }
        }

        public string Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public string COD_SEC
        {
            get { return _cOD_SEC; }
            set { _cOD_SEC = value; }
        }

        public string DEN_SEC { get; set; }

        public string TipIO { get; set; }

        public DateTime DataTermenLimitaRaspuns { get; set; }

        public bool Finalizat { get; set; }

        public int An { get; set; }

        public List<FluxDocumentRegistraturaInfo> Flux { get; set; }

        public bool ModificatServer { get; set; }
        public bool ModificatMobil { get; set; }
        public DateTime DataModificatServer { get; set; }
        public DateTime DataModificatMobil { get; set; }
        public string DocumentId { get; set; }
        public string UserUltimaModificare { get; set; }

        public int TipDocInternExtern { get; set; }
        public string NrInregistrareExterior { get; set; }
        public bool PredatFizic { get; set; }

    }
}
