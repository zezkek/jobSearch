using System.ComponentModel;

namespace jobSearch.Models
{
    public class Vacancy : BasicObject
    {

        #region Fields

        private string? _descriprion;
        private decimal? _salary;
        private Firm? _firm;

        #endregion

        #region Properties

        [DisplayName("Описание")]
        public string? Description { get => _descriprion; set => _descriprion = value; }

        [DisplayName("Зарплата")]
        public decimal? Salary { get => _salary; set => _salary = value; }

        [DisplayName("Компания")]
        public Firm? Firm { get => _firm; set => _firm = value; }

        #endregion
    }
}
