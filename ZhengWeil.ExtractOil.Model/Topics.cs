//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZhengWeil.ExtractOil.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Topics
    {
        public Topics()
        {
            this.Replys = new HashSet<Replys>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public Nullable<System.DateTime> AddDate { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public string UserHostAddress { get; set; }
        public Nullable<System.DateTime> LastModifyDate { get; set; }
    
        public virtual ICollection<Replys> Replys { get; set; }
    }
}
