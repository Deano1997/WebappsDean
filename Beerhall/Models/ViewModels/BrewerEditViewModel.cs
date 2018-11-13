using Beerhall.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beerhall.Models.ViewModels {
    public class BrewerEditViewModel { 
        public String Name { get; set; }
        public String Street { get; set; }

        public String Postalcode { get; set; }
        public int? Turnover { get; set; }

        public BrewerEditViewModel(Brewer brewer) {
            Name = brewer.Name;
            Street = brewer.Street;
            Postalcode = brewer.Location?.PostalCode; //de location is optional dus kan null zijn, door ? te zetten behoed jezelf voor null referations
            Turnover = brewer.Turnover;
        }
    }
}
