using EduRp.Data;
using EduRp.Data.ViewModel;
using EduRp.Service.IService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduRp.Service.Service
{
    public class StudentAdmissionFormService : IStudentAdmissionFormService
    {
        private encomp_devEntities db = new encomp_devEntities();

        public List<GetApplicationFormDetail_Result> GetApplicationFormDetail(int? id, int? userid, string tokenid, string admissionnumber)
        {
            var result=  db.GetApplicationFormDetail(id, userid, tokenid, admissionnumber).ToList();

            return result;
        }

        public List<GetApplicationFormDocumentDetail_Result> GetDocumentAccordion(int? id, int? userid, string tokenid, string admissionnum)
        {
            return db.GetApplicationFormDocumentDetail(id, userid, tokenid, admissionnum).ToList();
        }

        public List<GetApplicationFormHeader_Result> GetApplicationHeader(int? id, int? userid, string tokenid, string admissionnum)
        {
            return db.GetApplicationFormHeader(id, userid, tokenid, admissionnum).ToList();
        }

        public List<GetApplicationFormFeeDetail_Result> GetApplicationFee(int? id, int? userid, string tokenid, string admissionnum)
        {
            throw new NotImplementedException();
        }
        
        public bool UpdateApplicationForm(int? id, List<UpdateStudentApplicationFormDetail> applicationFormDetail)
        {
            try
            {
                var stdformObj = JsonConvert.SerializeObject(applicationFormDetail);

                var JsonObj = db.UpdateApplicationForm(applicationFormDetail[0].UniversityId, stdformObj);

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
            throw new NotImplementedException();
        }

        public bool UpdateDocument(int? id, List<GetApplicationFormDocumentDetail_Result> applicaitonFormDocument)
        {
            try
            {
                var stddocObj = JsonConvert.SerializeObject(applicaitonFormDocument);

                var JsonObj = db.UpdateApplicationFormDocument(applicaitonFormDocument[0].UniversityId, stddocObj);

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
            throw new NotImplementedException();

        }

        public bool UpdateHeader(int? id, List<GetApplicationFormHeader_Result> applicationFormHaeder)
        {
            try
            { 
                
                var stdheaderObj = JsonConvert.SerializeObject(applicationFormHaeder);

                var JsonObj = db.UpdateApplicationFormHeader(applicationFormHaeder[0].UniversityId, stdheaderObj);

                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("NotImplementedException", ex);
                return false;
            }
            throw new NotImplementedException();
        }

        public List<GetApplicationFormGroupDetail_Result> GetApplicatonGroup(int? id, int? userid, string tokenid,string admissionnum)
        {
            return db.GetApplicationFormGroupDetail(id, userid, tokenid, admissionnum).ToList();
        }

        public List<GetApplicationFormFieldDetail_Result> GetApplicationField(int? id, int? userid, string tokenid, string admissionnum)
        {
            return db.GetApplicationFormFieldDetail(id, userid, tokenid, admissionnum).ToList();
        }

    }

}