using EduRp.Data;
using EduRp.Service.IService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EduRp.Service.Service
{
    public class AcademicConductService : IAcademicConductService
    {
        encomp_devEntities db = new encomp_devEntities();

        public List<AcadConductLetterPermisGet_Result> AcadConductLetterPermisGet(int? id,int? userid,string token,int? batchid,int? programstudyid,int? courseid,int? studentid)
        {
            return db.AcadConductLetterPermisGet(id, userid, token, batchid, programstudyid, courseid, studentid).ToList();
        }

        public bool AcadConductLetterPermisUpdate(int? id ,AcadConductLetterPermi acadConductLetterPermis)
        {
            try
            {
                var acadConductLetterPermisObj = JsonConvert.SerializeObject(acadConductLetterPermis);

                var JsonObj = db.AcadConductLetterPermisUpdate(id, acadConductLetterPermisObj);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
        }

        public List<AcadConductLostFoundGet_Result> AcadConductLostFoundGet(int? id, int? userid, string token, int? batchid, int? programstudyid, int? courseid, int? studentid)
        {
            return db.AcadConductLostFoundGet(id, userid, token, batchid, programstudyid, courseid, studentid).ToList();
        }

        public bool AcadConductLostFoundUpdate(int? id, AcadConductLostFound acadConductLostFound)
        {
            try
            {
                var acadConductLostFoundObj = JsonConvert.SerializeObject(acadConductLostFound);

                var JsonObj = db.AcadConductLostFoundUpdate(id, acadConductLostFoundObj);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
        }

        public List<AcadConductMeritDemeritGet_Result> AcadConductMeritDemeritGet(int? id, int? userid, string token, int? batchid, int? programstudyid, int? courseid, int? studentid)
        {
            return db.AcadConductMeritDemeritGet(id, userid, token, batchid, programstudyid, courseid, studentid).ToList();
        }

        public bool AcadConductMeritDemeritUpdate(int? id , AcadConductMeritDemerit acadConductMeritDemerit)
        {
            try
            {
                var acadConductMeritDemeritObj = JsonConvert.SerializeObject(acadConductMeritDemerit);

                var JsonObj = db.AcadConductMeritDemeritUpdate(id, acadConductMeritDemeritObj);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
        }

        public List<AcadConductMYLGet_Result> AcadConductMYLGet(int? id, int? userid, string token, int? batchid, int? programstudyid, int? courseid, int? studentid)
        {
            return db.AcadConductMYLGet(id, userid, token, batchid, programstudyid, courseid, studentid).ToList();
        }

        public bool AcadConductMYLUpdate(int? id, AcadConductMYL acadConductMYL)
        {
            try
            {
                var acadConductMYLObj = JsonConvert.SerializeObject(acadConductMYL);

                var JsonObj = db.AcadConductMYLUpdate(id, acadConductMYLObj);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
        }

        public List<AcadConductStudentCharacterGet_Result> AcadConductStudentCharacterGet(int? id, int? userid, string token, int? batchid, int? programstudyid, int? courseid)
        {
            return db.AcadConductStudentCharacterGet(id, userid, token, batchid, programstudyid, courseid).ToList();
        }

        public bool AcadConductStudentCharacterUpdate(int? id , AcadConductStudentCharacter acadConductStudentCharacter)
        {
            try
            {
                var acadConductStudentCharacterObj = JsonConvert.SerializeObject(acadConductStudentCharacter);

                var JsonObj = db.AcadConductStudentCharacterUpdate(id, acadConductStudentCharacterObj);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
        }
    }
}