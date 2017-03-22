namespace AutoSalon.Domain.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource),ErrorMessageResourceName = "The_field_Is_Required")]
        [MaxLength(200, ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Maximum_Length_Of_String_Reached")]
        public string Brand { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "The_field_Is_Required")]
        [Range(0, int.MaxValue, ErrorMessageResourceType = typeof(Resource), 
            ErrorMessageResourceName = "Value_Of_The_Field_Must_Be_A_Positive_Number")]
        public int YearOfManufacture { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "The_field_Is_Required")]
        [Range(0, int.MaxValue, ErrorMessageResourceType = typeof(Resource),
            ErrorMessageResourceName = "Value_Of_The_Field_Must_Be_A_Positive_Number")]
        public int Horsepower { get; set; }
        
        [MaxLength(200, ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "Maximum_Length_Of_String_Reached")]
        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "The_field_Is_Required")]
        public string Importer { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resource), ErrorMessageResourceName = "The_field_Is_Required")]
        public string Description { get; set; }
    }
}
