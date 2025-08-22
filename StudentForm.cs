using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class StudentForm
    {
        public void FormCreate()
        {
            Console.WriteLine("Enter Full Name");
            string FullName = Console.ReadLine();
            Console.WriteLine("Enter Date of Birth (dd/mm/yyyy)");
            string DoB = Console.ReadLine();
            Console.WriteLine("Enter Gender (Male/Female)");
            string Gender = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter Blood Group (Eg. A+)");
            string BldGrp = Console.ReadLine();
            Console.WriteLine("Enter Identity Marks");
            string IdMarks = Console.ReadLine();
            Console.WriteLine("Enter Father's Name");
            string FName = Console.ReadLine();
            Console.WriteLine("Enter Father's Occupation");
            string FaOcu = Console.ReadLine();
            Console.WriteLine("Enter Mother's Name");
            string MName = Console.ReadLine();
            Console.WriteLine("Enter Mother's Occupation");
            string MoOcu = Console.ReadLine();
            Console.WriteLine("Enter Guardian's Name(if any)");
            string GName = Console.ReadLine();          
            Console.WriteLine("Enter Guardian's Occupation(if any)");
            string GaOcu = Console.ReadLine();
            Console.WriteLine("Enter Parent/Guardian mobile number");
            string MoNum = Console.ReadLine();
            DateTime now = DateTime.Now;
            string onlyDate = now.ToString("yyyy-MM-dd");



            string filePath = @"D:\DemoCreation\StudentAdmissionForm.pdf";

            Document doc = new Document(PageSize.A4);

            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();

            Font titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18);
            Paragraph title = new Paragraph("New Student Admission Form", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            doc.Add(new Paragraph("\n\n"));

            Font sectionFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
            doc.Add(new Paragraph("Student Information", sectionFont));
            doc.Add(new Paragraph($"Full Name : {FullName}"));
            doc.Add(new Paragraph($"Date of Birth : {DoB}"));
            doc.Add(new Paragraph($"Gender : {Gender}"));
            doc.Add(new Paragraph($"Address : {Address}"));
            doc.Add(new Paragraph($"Blood Group : {BldGrp}"));
            doc.Add(new Paragraph($"Identity Marks : {IdMarks}"));
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph("Parent/Guardian Details", sectionFont));
            doc.Add(new Paragraph($"Father's Name : {FName}"));
            doc.Add(new Paragraph($"Father's Occupation : {FaOcu}"));
            doc.Add(new Paragraph($"Mother's Name : {MName}"));
            doc.Add(new Paragraph($"Mother's Occupation : {MoOcu}"));
            doc.Add(new Paragraph($"Guardian's Name(if any) : {GName}"));
            doc.Add(new Paragraph($"Guardian's Occupation(if any) : {GaOcu}"));
            doc.Add(new Paragraph($"Mobile Number : {MoNum}"));
            doc.Add(new Paragraph($"Address : {Address}"));
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph("Emergency Contact", sectionFont));
            doc.Add(new Paragraph($"Name : {FName}"));
            doc.Add(new Paragraph($"Phone : {MoNum}"));
            doc.Add(new Paragraph("Relationship : Father"));
            doc.Add(new Paragraph($"Address : {Address}"));
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph("Previous School Details", sectionFont));
            doc.Add(new Paragraph("School Name : ABC Hr. Sec. School"));
            doc.Add(new Paragraph("Last Grade Completed : X"));
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph("Declaration", sectionFont));
            doc.Add(new Paragraph("I hereby declare that the information provided above is true and correct to the best of my knowledge."));
            doc.Add(new Paragraph("\n {Sign}"));
            doc.Add(new Paragraph("Signature of Parent/Guardian"));
            doc.Add(new Paragraph($"Date : {onlyDate}"));

            Console.WriteLine("PDF created successfully at " + filePath);

            doc.Close();

        }
    }
}
