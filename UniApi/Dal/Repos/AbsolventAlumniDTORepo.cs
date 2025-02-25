using System;
using System.Collections.Generic;
using AGSIS.Components.Repos;
using AGSIS.Components.Info;

namespace AGSIS.Components.Controller
{
    public class AbsolventAlumniDTOController
    {
        private readonly AbsolventAlumniDTORepo _repo;

        public AbsolventAlumniDTOController()
        {
            _repo = new AbsolventAlumniDTORepo();
        }

        public List<AbsolventAlumniDTO> AbsolventAlumniDTOGetList(long id_facultate, long id_anUniv, long id_specializare, long id_FacultateCiclu, long id_FCForma)
        {
            return _repo.AbsolventAlumniDTOGetList(id_facultate, id_anUniv, id_specializare, id_FacultateCiclu, id_FCForma);
        }
    }
}
