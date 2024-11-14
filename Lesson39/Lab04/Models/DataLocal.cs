/// <summary>
/// DataLocal: chữa dữ liệu và các phương thức thực hiện các chức năng CRUD
/// </summary>
namespace Lab04.Models
{
    public class DataLocal
    {
        public static List<People> _peoples = new List<People>()
        {
            new People (){
                Id = 1,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/1.jpg",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =0
            },
            new People (){
                Id = 2,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/2.jpg",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =1
            },
            new People (){
                Id = 3,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/3.jpg",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =1
            },
            new People (){
                Id = 4,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/4.jpg",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =2
            },
            new People (){
                Id = 5,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/5.jpg",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =0
            },
            new People (){
                Id = 6,
                Name = "Ronaldo",
                Email="ronaldo@gmail.com",
                Phone = "0987656432",
                Address = "Bồ Đào Nha",
                Avatar = "/images/avatar/6.jpg",
                Bio = "Cầu thủ đá bóng của đội tuyển Bồ Đào Nha",
                Birthday = new DateTime(1986/4/7),
                Gender =1
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
