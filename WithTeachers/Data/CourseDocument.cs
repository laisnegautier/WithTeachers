using BlazorInputFile;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WithTeachers.Data
{
    public class CourseDocument
    {
        public int CourseDocumentId { get; set; }

        public int Index { get; set; }

        [NotMapped]
        public IFileListEntry File { get; set; } = null;

        [NotMapped]
        public bool IsUploadOK { get; set; } = true;

        [NotMapped]
        public double Progress { get { if (File != null) return (File.Data.Position * 100.0) / File.Size; else return 0; } }

        [Required(ErrorMessage = "The document title should not be left empty.")]
        public string Title { get; set; }

        [DataType(DataType.Url)]
        public string FileUrl { get; set; }

        [DataType(DataType.Date)]
        public DateTime UploadDate { get; set; }

        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}