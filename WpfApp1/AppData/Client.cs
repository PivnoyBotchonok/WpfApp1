//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.Flat = new HashSet<Flat>();
            this.House = new HashSet<House>();
            this.Region = new HashSet<Region>();
        }
    
        public int ID { get; set; }
        public int RoleID { get; set; }
        public string SName { get; set; }
        public string FName { get; set; }
        public string PName { get; set; }
        public string Number { get; set; }
        public string Emaill { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Свойство, возвращающее ФИО клиента в формате "Фамилия И.О.".
        /// Например, для клиента с фамилией "Иванов", именем "Иван" и отчеством "Иванович"
        /// значение будет "Иванов И.И.".
        /// </summary>
        public string FIO
        {
            get
            {
                return $"{SName} {FName[0]}.{PName[0]}.";
            }
        }

        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flat> Flat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<House> House { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Region> Region { get; set; }
    }
}
