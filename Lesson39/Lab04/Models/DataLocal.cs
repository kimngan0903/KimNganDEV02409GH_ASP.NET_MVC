/// <summary>
/// DataLocal: chữa dữ liệu và các phương thức thực hiện các chức năng CRUD
/// </summary>
namespace Lab04.Models
{
    public class DataLocal
    {
        public static List<People> _peoples = new List<People>()
        {
            new People()
            {
                Id = 1,
                Name = "Devmaster",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "0987543222",
                Address = "25 Vũ Ngọc Phan",
                Avatar = "images/avatar/1.jpg",
                Birthday = Convert.ToDateTime("2024/11/12"),
                Bio = "Viện Công nghệ Devmaster",
                Gender = 0
            },
            new People()
            {
                Id = 2,
                Name = "Devmaster",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "0987543222",
                Address = "25 Vũ Ngọc Phan",
                Avatar = "images/avatar/2.jpg",
                Birthday = Convert.ToDateTime("2024/11/12"),
                Bio = "Viện Công nghệ Devmaster",
                Gender = 2
            },
            new People()
            {
                Id = 3,
                Name = "Devmaster",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "0987543222",
                Address = "25 Vũ Ngọc Phan",
                Avatar = "images/avatar/3.jpg",
                Birthday = Convert.ToDateTime("2024/11/12"),
                Bio = "Viện Công nghệ Devmaster",
                Gender = 0
            },
            new People()
            {
                Id = 4,
                Name = "Devmaster",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "0987543222",
                Address = "25 Vũ Ngọc Phan",
                Avatar = "images/avatar/4.jpg",
                Birthday = Convert.ToDateTime("2024/11/12"),
                Bio = "Viện Công nghệ Devmaster",
                Gender = 1
            },
            new People()
            {
                Id = 5,
                Name = "Devmaster",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "0987543222",
                Address = "25 Vũ Ngọc Phan",
                Avatar = "images/avatar/5.jpg",
                Birthday = Convert.ToDateTime("2024/11/12"),
                Bio = "Viện Công nghệ Devmaster",
                Gender = 2
            },
            new People()
            {
                Id = 6,
                Name = "Devmaster",
                Email = "devmaster.edu.vn@gmail.com",
                Phone = "0987543222",
                Address = "25 Vũ Ngọc Phan",
                Avatar = "images/avatar/6.jpg",
                Birthday = Convert.ToDateTime("2024/11/12"),
                Bio = "Viện Công nghệ Devmaster",
                Gender = 1
            },
        };

        /// <summary>
        /// GetPeoples: Lấy danh sách dữ liệu Peoples
        /// </summary>
        /// <returns></returns>
        public static List<People> GetPeoples()
        {
            return _peoples;
        }

        /// <summary>
        /// GetPeopleById: Lấy đối tượng peoples theo id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns>peoples</returns>
        public static People? GetPeopleById(int Id)
        {
            var people = _peoples.FirstOrDefault(x => x.Id == Id);
            return people;
        }
    }
}
