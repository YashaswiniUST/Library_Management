using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Contracts.Enums;

namespace BookManagement.API.Models
{
    public class Issue
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IssueId { get; set; }

        public int BookId { get; set; }
        public int StudentId { get; set; }

        public Status status { get; set; }
    }
}
