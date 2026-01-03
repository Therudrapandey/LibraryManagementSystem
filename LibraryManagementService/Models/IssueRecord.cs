namespace LibraryManagementService.Models.IssueRecord;

public class IssueRecord{
        public int Id { get; set; }
        public string BookName{ get; set; }
        public int UserId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ReturnDate { get; set; }
}
