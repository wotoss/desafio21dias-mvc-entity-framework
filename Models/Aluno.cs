
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mvc_entity.Models
{
    //Reflechãm é uma classe para ler dados de outra classe.
    [Table("tb_aluno")]
    public partial  class Aluno
    {

  #region "Alunos propriedades"
        [Key]
        [Column("id")]
        public int Id {get; set;}

        [Column("nome", TypeName = "varchar")]
        [Required]
        [MaxLength(150)]
        public string Nome {get; set;}

        [Column ("matricula", TypeName = "varchar")]
        [Required]
        [MaxLength(8)]
        public string Matricula {get; set;}

        [Column("notas", TypeName = "text")]
        [Required]
        public string Notas { get ; set ; }
        
    }
}
    #endregion

    #region Métodos de Instancia

//            public string StrNotas()
//            {
//             return string.Join(",", this.Notas.ToArray());
//           }
//            public double CalcularMedia()
//            {
//             var somaNotas = 0.0;
//             foreach (var nota in this.Notas)
//             {
//                 somaNotas += nota;
//             }
//             return somaNotas / this.Notas.Count;
//           }

//           public string Situacao()
//           {
//              return this.CalcularMedia() >= 7 ? "Aprovado" : "Reprovado";
//           }
          
//          public void Salvar()
//          {
//            if(this.Id > 0)
//            {
//              Aluno.Atualizar(this);
//            }
//             else
//             {
//               Aluno.Incluir(this);
//             }
//           }
           
//            //Este é um método de instância. E o ApagarPorId é um método statico.
//            public void Apagar()
//            {
//              Aluno.ApagarPorId(this.Id);
//            }
//     }
// }


  #endregion



   

