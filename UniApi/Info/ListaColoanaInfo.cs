using System;

namespace UniApi.Info
{
    public partial class ListaColoanaInfo
    {
        private Guid _idListaColoane;
        private Guid _idLista;
        private int _pozitieColoana;
        private string _denumireColoana;
        private string _DenumireColoanaAfisata;
        private int _lungimeColoana;

        public ListaColoanaInfo()
        {
        }

        public ListaColoanaInfo(Guid idListaColoane, Guid idLista, int pozitieColoana, string denumireColoana, string DenumireColoanaAfisata, int lungimeColoana)
        {
        }

        public Guid IdListaColoane
        {
            get { return _idListaColoane; }
            set { _idListaColoane = value; }
        }

        public Guid IdLista
        {
            get { return _idLista; }
            set { _idLista = value; }
        }

        public int PozitieColoana
        {
            get { return _pozitieColoana; }
            set { _pozitieColoana = value; }
        }

        public string DenumireColoana
        {
            get { return _denumireColoana; }
            set { _denumireColoana = value; }
        }

        public string DenumireColoanaAfisata
        {
            get { return _DenumireColoanaAfisata; }
            set { _DenumireColoanaAfisata = value; }
        }

        public int LungimeColoana
        {
            get { return _lungimeColoana; }
            set { _lungimeColoana = value; }
        }


        private string _Separator;

        public string Separator
        {
            get { return _Separator; }
            set { _Separator = value; }
        }
    }
}