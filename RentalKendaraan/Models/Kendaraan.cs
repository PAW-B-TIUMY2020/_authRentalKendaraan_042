using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_042.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }


        public int IdKendaraan { get; set; }
        [Required(ErrorMessage = "Nama kendaraan tidak boleh kosong!")]
        public string NamaKendaraan { get; set; }
        [Required(ErrorMessage = "No Polisi tidak boleh kosong!")]
        public string NoPolisi { get; set; }
        [Required(ErrorMessage = "No Polisi tidak boleh kosong!")]
        public string NoStnk { get; set; }
        [Required(ErrorMessage = "No STNK tidak boleh kosong!")]
        public int? IdJenisKendaraan { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi angka!")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdJenisKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
