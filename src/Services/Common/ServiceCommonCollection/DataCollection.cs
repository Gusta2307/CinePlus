using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceCommonCollection
{
    public class DataCollection<T>
    {
        public IEnumerable<T> Items { get; set; } //coleccion con los registros

        public int TotalItems { get; set; } //cantidad de registros

        public int Page { get; set; } //pagina donde se encuentra

        public int Pages { get; set; } //cantidad de paginas generadas por la paginacion

        public bool HasItems { get { return Items != null && Items.Any(); } }

        public int Count { get; set; }
    }
}
