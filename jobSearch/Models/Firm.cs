using System.ComponentModel;

namespace jobSearch.Models
{
    public class Firm : BasicObject
    {
        #region Fields

        private string? _adress;
        private string? _description;

        #endregion

        #region Properties

        [DisplayName("Адрес")]
        public string? Adress { get => _adress; set => _adress = value; }

        [DisplayName("Описание")]
        public string? Description { get => _description; set => _description = value; }

        #endregion
    }
}
