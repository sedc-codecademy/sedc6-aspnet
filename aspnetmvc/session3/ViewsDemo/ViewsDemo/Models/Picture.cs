using System.ComponentModel.DataAnnotations;

namespace ViewsDemo.Models
{
    public class Picture
    {
        public int Id { get; set; }
        
        //[Custom("some error message","optional param",MinValue =1,MaxValue =10)]
        [Required(AllowEmptyStrings =false, ErrorMessage = "DisplayName is required")]
        public string DisplayName { get; set; }


        public string Url { get; set; }
    }
}