using System.ComponentModel.DataAnnotations;

namespace BlazorShop.Models;

public class Category
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo 'Título' é obrigatório")]
    [MinLength(3, ErrorMessage = "O campo 'Título' deve conter no mínimo 3 caracteres")]
    [MaxLength(60, ErrorMessage = "O campo 'Título' deve conter no máximo 60 caracteres")]
    public string Title { get; set; } = string.Empty;
}
