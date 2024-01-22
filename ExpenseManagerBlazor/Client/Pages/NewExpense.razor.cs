
using System.ComponentModel.DataAnnotations;

namespace ExpenseManagerBlazor.Client.Pages
{
    public partial class NewExpense
    {
        public ExpenseModel Expense;

        protected override Task OnInitializedAsync()
        {
            Expense = new();

            return base.OnInitializedAsync();
        }

        protected void Save() { 
        
            var i = 0;
        
        }

    }

    public class ExpenseModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Concept { get; set; }
        [Required]
        public string Description { get; set; }
        [Range(1, double.MaxValue, ErrorMessage = "La cantidad minima a ingresar tiene que er $1")]
        public double Total { get; set; }


    }
}
