using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }
        [DisplayName("Titulo")]
        [Required(ErrorMessage ="Campo Obrigatorio")]
        public string Title { get; set; }= string.Empty;
        [DisplayName("Concluido")]
        public bool Done { get; set; }
        public DateTime Createdat { get; set; } = DateTime.Now;
        public DateTime LastUpdatedate { get; set;} = DateTime.Now;
        public string User { get; set; } = string.Empty;
    }
}