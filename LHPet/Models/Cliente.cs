using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LHPet.Models
{
    [Table("Cliente")]
    public class Cliente
    {
       
            [Key]
            [Column("Id")]
            [Display(Name = "Id")]
            public int Id { get; set; }

            [Column("Nome")]
            [Display(Name = "Nome")]
            public string Nome { get; set; }

            [Column("Cpf")]
            [Display(Name = "Cpf")]
            public string Cpf { get; set; }

            [Column("Email")]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Column("Paciente")]
            [Display(Name = "Paciente")]
            public string Paciente { get; set; }

        }

    }


