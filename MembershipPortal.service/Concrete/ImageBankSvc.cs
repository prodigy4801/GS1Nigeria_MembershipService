using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MembershipPortal.core;
using MembershipPortal.data;

namespace MembershipPortal.service.Concrete
{
    public class ImageBankSvc : IImageBankSvc
    {
        private readonly IUnitOfWork _uow;
        private string[] _includes = { };

        public ImageBankSvc(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<GenericResponseList<ImageBank>> GetAll()
        {
            try
            {
                var records = await _uow.ImageBankRP.GetAll();
                return new GenericResponseList<ImageBank> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ImageBank> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
        public async Task<GenericResponseList<ImageBank>> GetAll(int? skip, int? take)
        {
            try
            {
                var records = await _uow.ImageBankRP.GetBy(null, x => x.OrderByDescending(y => y.id), skip, take, _includes);
                return new GenericResponseList<ImageBank> { ReturnedObject = records, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponseList<ImageBank> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageBank>> GetByID(int id)
        {
            try
            {
                var record = await _uow.ImageBankRP.GetByFirstOrDefault(x => x.id == id, _includes);
                return new GenericResponse<ImageBank> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageBank> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageBank>> GetByRegistrationID(string registrationid)
        {
            try
            {
                var record = await _uow.ImageBankRP.GetBySingleOrDefault(x => x.registrationid == registrationid, _includes);
                return new GenericResponse<ImageBank> { ReturnedObject = record, IsSuccess = true, Message = null };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageBank> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public string GenerateImage1(string gtin, bool approved, int width = 300, int height = 150)
        {
            byte[] imageBytes;
            using(var ms = new System.IO.MemoryStream())
            {
                imageBytes = ms.ToArray();
            }

            string base64String = Convert.ToBase64String(imageBytes);
            if (approved) return base64String;

            string tmp = Helpers.ImageManipulation.addWatermark(base64String);
            return tmp;
        }

        //internal string GeneratorImage2(Ean13 ean, string productGTIN, bool v)
        //{

        //    string myb64 = "";


        //    ean.Scale = (float)Convert.ToDecimal("2.0");

        //    Metafile mf = ean.CreateMetafile("~/images/barcodes/" + productGTIN + ".wmf");
        //    Metafile mf = ean.CreateMetafile();

        //    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
        //    {
        //        mf.Save(ms, ImageFormat.Png);
        //        myb64 = Convert.ToBase64String(ms.ToArray());
        //    }


        //    return myb64;
        //}

        public string GenerateITF14(string itf14, string fname)
        {
            int _width = 600;
            int _height = 300;
            string b64 = "";
            BarcodeLib.Barcode b = new BarcodeLib.Barcode();
            b.Alignment = BarcodeLib.AlignmentPositions.CENTER;

            BarcodeLib.TYPE type = BarcodeLib.TYPE.ITF14;
            b.IncludeLabel = true;
            b.Height = _height;
            b.Width = _width;
            b.AspectRatio = 4.0;
            b.LabelPosition = BarcodeLib.LabelPositions.BOTTOMCENTER;
            b.BackColor = System.Drawing.Color.White;
            b.ForeColor = System.Drawing.Color.Black;
            b.EncodedType = type;
            System.Drawing.Image genImage = b.Encode(type, itf14, _width, _width);



            MemoryStream metafileStream = Helpers.ImageManipulation.MakeMetafileStream(new System.Drawing.Bitmap(genImage), fname);




            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                genImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                b64 = Convert.ToBase64String(ms.ToArray());
            }
            return "data:image/jpeg;base64," + b64;
        }

        public async Task<GenericResponse<ImageBank>> Remove(ImageBank obj)
        {

            try
            {
                _uow.ImageBankRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ImageBank> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ImageBank> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageBank> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageBank>> Remove(int id)
        {

            try
            {
                var obj = _uow.ImageBankRP.GetById(id);
                _uow.ImageBankRP.Delete(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ImageBank> { ReturnedObject = null, IsSuccess = true, Message = "Successfully deleted record." };
                }
                return new GenericResponse<ImageBank> { ReturnedObject = null, IsSuccess = false, Message = "Failed to delete record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageBank> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }

        public async Task<GenericResponse<ImageBank>> Save(ImageBank profile)
        {
            if (profile.id == 0)
            {
                profile.createdOn = DateTime.Now;
                return await Add(profile);
            }
            else
            {
                profile.lastModified = DateTime.Now;
                return await Update(profile.id, profile);
            }
        }

        private async Task<GenericResponse<ImageBank>> Add(ImageBank profile)
        {
            try
            {
                if (!await _uow.ImageBankRP.AnyAsync(y => y.registrationid == profile.registrationid))
                {
                    _uow.ImageBankRP.Add(profile);
                    int result = await _uow.Complete();
                    if (result > 0)
                    {
                        return new GenericResponse<ImageBank> { ReturnedObject = profile, IsSuccess = true, Message = "Successfully added record." };
                    }
                    return new GenericResponse<ImageBank> { ReturnedObject = null, IsSuccess = false, Message = "Failed adding record." };
                }  
                return new GenericResponse<ImageBank> { ReturnedObject = null, IsSuccess = false, Message = "User Profile already exist in storage." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageBank> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }

        }
        private async Task<GenericResponse<ImageBank>> Update(int id, ImageBank obj)
        {

            try
            {
                _uow.ImageBankRP.Update(obj);
                int result = await _uow.Complete();
                if (result > 0)
                {
                    return new GenericResponse<ImageBank> { ReturnedObject = obj, IsSuccess = true, Message = "Successfully updated record." };
                }
                return new GenericResponse<ImageBank> { ReturnedObject = null, IsSuccess = false, Message = "Failed updating record." };
            }
            catch (Exception ex)
            {
                return new GenericResponse<ImageBank> { Message = ex.Message, ReturnedObject = null, IsSuccess = false };
            }
        }
    }
}
