using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Google.Model.Entities
{
    public class Log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; private set; }

        public string Application { get; private set; }

        public string Logged { get; private set; }

        public string Level { get; private set; }

        public string Message { get; private set; }

        public string Logger { get; private set; }

        public string Callsite { get; private set; }

        public string Exception { get; private set; }
    }
}