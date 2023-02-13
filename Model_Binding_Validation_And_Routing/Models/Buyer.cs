using System.ComponentModel.DataAnnotations;

namespace Model_Binding_Validation_And_Routing.Models
{
    public class Buyer
    {
        [Required(ErrorMessage = "Vui lòng nhập tên người nhận")]
        [StringLength(maximumLength: 25, MinimumLength = 10, ErrorMessage = "Length must be between 10 to 25")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập địa chỉ nhận hàng của bạn")]
        [StringLength(maximumLength: 200, ErrorMessage = "Length must be small than 200 character")]
        public string Address { get; set; }

        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Số điện thoại không hợp lệ")]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}
