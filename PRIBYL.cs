//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace train3
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRIBYL
    {
        public int IDP { get; set; }
        public string DATA { get; set; }
        public string PRIBYL_ZA_DAY { get; set; }
        public Nullable<int> ID { get; set; }
    
        public virtual USERS USERS { get; set; }
    }
}