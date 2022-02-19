using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork10_Sort
{
    public class Hospital: IComparable<Hospital>
    {
        public string NameCabinet { get; set; }
        public int IdCabinet { get; set; }
        public string FullName { get; set; }
        public int ReceptionDay { get; set; }
        public DateTime StartReception { get; set; }
        public DateTime EndReception { get; set; }

        public Hospital(string nameCabinet, int idCabinet, string fullName, int receptionDay, DateTime startReception, DateTime endReception)
        {
            NameCabinet = nameCabinet ?? throw new ArgumentNullException(nameof(nameCabinet));
            IdCabinet = idCabinet;
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            ReceptionDay = receptionDay;
            StartReception = startReception;
            EndReception = endReception;
        }

        public override string ToString()
        {
            return $"{NameCabinet,-18} | {IdCabinet,-7} | {FullName,-24} | {ReceptionDay,10} | {StartReception.ToString("t"),-13} | {EndReception.ToString("t"),-10}";
        }



        public int CompareTo(Hospital hospital)
        {
            return IdCabinet.CompareTo(hospital.IdCabinet);
        }
        public class SortByNameCabinet : IComparer<Hospital>
        {
            public int Compare(Hospital x, Hospital y)
            {
                return x.NameCabinet.CompareTo(y.NameCabinet);
            }
        }
        public class SortByFullName : IComparer<Hospital>
        {
            public int Compare(Hospital x, Hospital y)
            {
                return x.FullName.CompareTo(y.FullName);
            }
        }
        public class SortByStartReception : IComparer<Hospital>
        {
            public int Compare(Hospital x, Hospital y)
            {
                return x.StartReception.CompareTo(y.StartReception);
            }
        }
    }
}
