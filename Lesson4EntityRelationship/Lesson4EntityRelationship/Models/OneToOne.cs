using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson4EntityRelationship.Models
{
    #region Default convension

    //public class Role
    //{
    //    public int Id { get; set; }
    //    public string RoleName { get; set; } = null!;
    //    public User User { get; set; }
    //}

    //public class User
    //{
    //    //public int ID { get; set; }
    //    //public int UserId { get; set; }
    //    //public int UserID { get; set; }
    //    public int Id { get; set; }
    //    public string Name { get; set; } = null!;
    //    public string Email { get; set; } = null!;
    //    public string Password { get; set; } = null!;
    //    public bool IsConfirmEmail { get; set; }
    //    public int RoleId { get; set; }
    //    public Role Role { get; set; }

    //}

    #endregion
    #region FluentApi
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; } = null!;
        public User User { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Role Role { get; set; }

    }
    #endregion
    #region DataAnnotation
    //public class User
    //{
    //    //public int ID { get; set; }
    //    //public int UserId { get; set; }
    //    //public int UserID { get; set; }
    //    [Key]
    //    public int Id { get; set; }
    //    public string Name { get; set; } = null!;
    //    public string Email { get; set; } = null!;
    //    public string Password { get; set; } = null!;
    //    public bool IsConfirmEmail { get; set; }
    //}


    //public class Role
    //{
    //    [Key, ForeignKey(nameof(User))]
    //    public int Id { get; set; }
    //    public string RoleName { get; set; } = null!;
    //    public User User { get; set; }
    //}

    //public class User
    //{
    //    //public int ID { get; set; }
    //    //public int UserId { get; set; }
    //    //public int UserID { get; set; }
    //    public int Id { get; set; }
    //    public string Name { get; set; } = null!;
    //    public Role Role { get; set; }

    //}
    #endregion
}
