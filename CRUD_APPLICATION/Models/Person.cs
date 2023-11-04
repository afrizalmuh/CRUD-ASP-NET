using System.ComponentModel.DataAnnotations;

namespace CRUD_APPLICATION.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        public int Nik { get; set; }

        public string Name { get; set; } = null!;

        public string Alamat { get; set; } = null!;

        public string StatusPerkawinan { get; set; } = null!;

    }
}
