using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.models;

internal class CV
{
    public string Profession { get; set; }
    public string School { get; set; }
    public double UniExam { get; set; }
    public string? Skills { get; set; }
    public string? Companies { get; set; }
    public string? Languages { get; set; }
    public string? Certification { get; set; }
    public string GitLink { get; set; }
    public string LinkedIn { get; set; }


    public CV(string prof, string school, double uniexam, string skills, string companies,
        string languages, string certification, string gitlink, string linkedin)
    {
        Profession= prof;
        School= school;
        UniExam= uniexam;
        Skills= skills;
        Companies= companies;
        Languages= languages;
        Certification= certification;
        GitLink= gitlink;
        LinkedIn= linkedin;
            
    }


    public override string ToString()
    {
        return $@"
Profession --> {Profession}
School --> {School}
Univercity Exam Results --> {UniExam}
Skills --> {Skills}
Companies --> {Companies}
Languages --> {Languages}
Certification --> {Certification}
Git Link --> {Certification}
Linked In --> {Certification}
";
    }

}
