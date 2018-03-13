using EduRp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.IService
{
    public interface IAcademicConductService
    {
        List<AcadConductLetterPermisGet_Result> AcadConductLetterPermisGet(int? id, int? userid, string tokenid,int? batchid, int? programstudyid, int? courseid, int? studentid);
        List<AcadConductLostFoundGet_Result> AcadConductLostFoundGet(int? id, int? userid, string tokenid, int? batchid, int? programstudyid, int? courseid, int? studentid);
        List<AcadConductMeritDemeritGet_Result> AcadConductMeritDemeritGet(int? id, int? userid, string tokenid, int? batchid, int? programstudyid, int? courseid, int? studentid);
        List<AcadConductStudentCharacterGet_Result> AcadConductStudentCharacterGet(int? id, int? userid, string tokenid, int? batchid, int? programstudyid, int? courseid);
        List<AcadConductMYLGet_Result> AcadConductMYLGet(int? id, int? userid, string tokenid,int? batchid, int? programstudyid, int? courseid, int? studentid);
        bool AcadConductLetterPermisUpdate(int? id, AcadConductLetterPermi acadConductLetterPermis);
        bool AcadConductLostFoundUpdate(int? id, AcadConductLostFound acadConductLostFound);
        bool AcadConductMeritDemeritUpdate(int? id, AcadConductMeritDemerit acadConductMeritDemerit);
        bool AcadConductMYLUpdate(int? id, AcadConductMYL acadConductMYL);
        bool AcadConductStudentCharacterUpdate(int? id, AcadConductStudentCharacter acadConductStudentCharacter);
    }
}
