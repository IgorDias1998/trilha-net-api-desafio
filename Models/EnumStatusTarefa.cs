using System.ComponentModel.DataAnnotations;

namespace TrilhaApiDesafio.Models
{
    public enum EnumStatusTarefa
    {
        [Display(Name="Pendente")]
        Pendente,

        [Display(Name="Finalizado")]
        Finalizado
    }
}