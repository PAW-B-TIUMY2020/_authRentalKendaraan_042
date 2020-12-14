using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace RentalKendaraan_042.Models
{
    public partial class Peminjaman
    {
        public Peminjaman()
        {
            Pengembalian = new HashSet<Pengembalian>();
        }
        [DisplayName("ID")]
        public int IdPeminjaman { get; set; }
        [Required(ErrorMessage = "Tanggal peminjaman tidak boleh kosong!")]
        public DateTime? TglPeminjaman { get; set; }
        [DisplayName("Kendaraan")]
        [Required(ErrorMessage = "Nama kendaraan tidak boleh kosong!")]
        public int? IdKendaraan { get; set; }
        [DisplayName("Customer")]
        [Required(ErrorMessage = "Nama customer tidak boleh kosong!")]
        public int? IdCustomer { get; set; }
        [DisplayName("Jaminan")]
        [Required(ErrorMessage = "Jaminan tidak boleh kosong!")]
        public int? IdJaminan { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        public int? Biaya { get; set; }

        [DisplayName("Customer")]
        public Customer IdCustomerNavigation { get; set; }
        [DisplayName("Jaminan")]
        public Jaminan IdJaminanNavigation { get; set; }
        [DisplayName("Kendaraan")]
        public Kendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Pengembalian> Pengembalian { get; set; }
    }
}
