using System.ComponentModel.DataAnnotations;

namespace TaskManagerApi.Models.Dto
{
    public class TskDto
    {

        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }


        public string Description { get; set; }
    }
}
