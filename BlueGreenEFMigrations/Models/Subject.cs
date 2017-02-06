using System;

namespace BlueGreenEFMigrations.Models
{
    public class Subject
    {
        public int Id { get; set; }

        [Obsolete]
        public string Title { get; set; }

        public string Name { get; set; }
    }
}