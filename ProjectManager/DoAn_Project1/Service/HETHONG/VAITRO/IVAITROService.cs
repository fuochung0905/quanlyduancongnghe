﻿using Model.BASE;
using Model.HETHONG.VAITRO.Dtos;
using Model.HETHONG.VAITRO.Requests;

namespace REPONSITORY.HETHONG.VAITRO
{
    public interface IVAITROService
    {
        BaseResponse<GetListPagingResponse> GetList(GetListPagingRequest request);
        BaseResponse<MODELVaiTro> GetById(GetByIdRequest request);
        BaseResponse<PostVaiTroRequest> GetByPost(GetByIdRequest request);
        BaseResponse<MODELVaiTro> Insert(PostVaiTroRequest request);
        BaseResponse<MODELVaiTro> Update(PostVaiTroRequest request);
        BaseResponse<string> DeleteList(DeleteListRequest request);
        BaseResponse<List<MODELCombobox>> GetAllForCombobox();
        BaseResponse<List<MODELVaiTro_PhanQuyen>> GetListPhanQuyenVaiTro(GetListPhanQuyenVaiTroRequest request);
        BaseResponse<MODELVaiTro_PhanQuyen> PostPhanQuyenVaiTro(PostPhanQuyenVaiTroRequest request);
    
    }
}
    