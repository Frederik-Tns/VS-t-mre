﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Model;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence;
using Vs_Toemrer_Lagerstyringssystemsprojekt.Persistence.MaterialRepositories;

namespace Vs_Toemrer_Lagerstyringssystemsprojekt.Business_Infrastructure
{
    // Denne klasse er en del af GRASP. Pure fabrication. man laver en klasse der ikke eksistere i domænet. det er de .9 pattern i GRASP
    public class MaterialSearchService
    {
        private WoodRepository _woodRepository;
        private NailRepository _nailRepository;
        private ScrewRepository _screwRepository;

        public MaterialSearchService(WoodRepository woodRepository, NailRepository nailRepository, ScrewRepository screwRepository)
        {
            _woodRepository = woodRepository;
            _nailRepository = nailRepository;
            _screwRepository = screwRepository;
        }

        public IEnumerable<IMaterial> SearchMaterials(string searchTerm)
        {
            // Get matching materials from each repository
            var woods = _woodRepository.Get(searchTerm).Cast<IMaterial>();
            var nails = _nailRepository.Get(searchTerm).Cast<IMaterial>();
            var screws = _screwRepository.Get(searchTerm).Cast<IMaterial>();

            // Combine all results into a single list
            return woods.Concat(nails).Concat(screws);    
        }
    }
}
