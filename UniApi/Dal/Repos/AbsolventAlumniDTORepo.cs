using System;
using System.Collections.Generic;
using UniApi.Dal.Repos;
using UniApi.Info;

namespace UniApi.Dal.Repos
{
    public class AbsolventAlumniDTORepo
    {
        private readonly AbsolventAlumniDTORepo _repo;

        public AbsolventAlumniDTORepo()
        {
            _repo = new AbsolventAlumniDTORepo();
        }

        public List<AbsolventAlumniDTO> AbsolventAlumniDTOGetList(long id_facultate, long id_anUniv, long id_specializare, long id_FacultateCiclu, long id_FCForma)
        {
            return _repo.AbsolventAlumniDTOGetList(id_facultate, id_anUniv, id_specializare, id_FacultateCiclu, id_FCForma);
        }
    }
}
