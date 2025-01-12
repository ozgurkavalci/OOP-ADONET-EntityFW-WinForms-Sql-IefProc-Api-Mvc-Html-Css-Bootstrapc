﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _25042022_İefprocServices
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ServicesEntities : DbContext
    {
        public ServicesEntities()
            : base("name=ServicesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hizmetler> Hizmetlers { get; set; }
        public virtual DbSet<HizmetOzellikler> HizmetOzelliklers { get; set; }
        public virtual DbSet<Musteriler> Musterilers { get; set; }
        public virtual DbSet<Siparisler> Siparislers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int HEkle(string hizmetAdi, string hizmetTanimi, Nullable<decimal> hizmetFiyat)
        {
            var hizmetAdiParameter = hizmetAdi != null ?
                new ObjectParameter("HizmetAdi", hizmetAdi) :
                new ObjectParameter("HizmetAdi", typeof(string));
    
            var hizmetTanimiParameter = hizmetTanimi != null ?
                new ObjectParameter("HizmetTanimi", hizmetTanimi) :
                new ObjectParameter("HizmetTanimi", typeof(string));
    
            var hizmetFiyatParameter = hizmetFiyat.HasValue ?
                new ObjectParameter("HizmetFiyat", hizmetFiyat) :
                new ObjectParameter("HizmetFiyat", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HEkle", hizmetAdiParameter, hizmetTanimiParameter, hizmetFiyatParameter);
        }
    
        public virtual int HG(Nullable<int> hizmetNo, string hizmetAdi, string hizmetTanimi, Nullable<decimal> hizmetFiyat)
        {
            var hizmetNoParameter = hizmetNo.HasValue ?
                new ObjectParameter("HizmetNo", hizmetNo) :
                new ObjectParameter("HizmetNo", typeof(int));
    
            var hizmetAdiParameter = hizmetAdi != null ?
                new ObjectParameter("HizmetAdi", hizmetAdi) :
                new ObjectParameter("HizmetAdi", typeof(string));
    
            var hizmetTanimiParameter = hizmetTanimi != null ?
                new ObjectParameter("HizmetTanimi", hizmetTanimi) :
                new ObjectParameter("HizmetTanimi", typeof(string));
    
            var hizmetFiyatParameter = hizmetFiyat.HasValue ?
                new ObjectParameter("HizmetFiyat", hizmetFiyat) :
                new ObjectParameter("HizmetFiyat", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HG", hizmetNoParameter, hizmetAdiParameter, hizmetTanimiParameter, hizmetFiyatParameter);
        }
    
        public virtual ObjectResult<HGor_Result> HGor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HGor_Result>("HGor");
        }
    
        public virtual int HOEkle(Nullable<int> hizmetOzellikHizmetNo, string hizmetAciklama, string hizmetOzellikEkstra)
        {
            var hizmetOzellikHizmetNoParameter = hizmetOzellikHizmetNo.HasValue ?
                new ObjectParameter("HizmetOzellikHizmetNo", hizmetOzellikHizmetNo) :
                new ObjectParameter("HizmetOzellikHizmetNo", typeof(int));
    
            var hizmetAciklamaParameter = hizmetAciklama != null ?
                new ObjectParameter("HizmetAciklama", hizmetAciklama) :
                new ObjectParameter("HizmetAciklama", typeof(string));
    
            var hizmetOzellikEkstraParameter = hizmetOzellikEkstra != null ?
                new ObjectParameter("HizmetOzellikEkstra", hizmetOzellikEkstra) :
                new ObjectParameter("HizmetOzellikEkstra", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HOEkle", hizmetOzellikHizmetNoParameter, hizmetAciklamaParameter, hizmetOzellikEkstraParameter);
        }
    
        public virtual int HOG(Nullable<int> hizmetOzellikNo, Nullable<int> hizmetOzellikHizmetNo, string hizmetAciklama, string hizmetOzellikEkstra)
        {
            var hizmetOzellikNoParameter = hizmetOzellikNo.HasValue ?
                new ObjectParameter("HizmetOzellikNo", hizmetOzellikNo) :
                new ObjectParameter("HizmetOzellikNo", typeof(int));
    
            var hizmetOzellikHizmetNoParameter = hizmetOzellikHizmetNo.HasValue ?
                new ObjectParameter("HizmetOzellikHizmetNo", hizmetOzellikHizmetNo) :
                new ObjectParameter("HizmetOzellikHizmetNo", typeof(int));
    
            var hizmetAciklamaParameter = hizmetAciklama != null ?
                new ObjectParameter("HizmetAciklama", hizmetAciklama) :
                new ObjectParameter("HizmetAciklama", typeof(string));
    
            var hizmetOzellikEkstraParameter = hizmetOzellikEkstra != null ?
                new ObjectParameter("HizmetOzellikEkstra", hizmetOzellikEkstra) :
                new ObjectParameter("HizmetOzellikEkstra", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HOG", hizmetOzellikNoParameter, hizmetOzellikHizmetNoParameter, hizmetAciklamaParameter, hizmetOzellikEkstraParameter);
        }
    
        public virtual ObjectResult<HOGor_Result> HOGor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HOGor_Result>("HOGor");
        }
    
        public virtual int HOSil(Nullable<int> hizmetOzellikNo)
        {
            var hizmetOzellikNoParameter = hizmetOzellikNo.HasValue ?
                new ObjectParameter("HizmetOzellikNo", hizmetOzellikNo) :
                new ObjectParameter("HizmetOzellikNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HOSil", hizmetOzellikNoParameter);
        }
    
        public virtual int HSil(Nullable<int> hizmetNo)
        {
            var hizmetNoParameter = hizmetNo.HasValue ?
                new ObjectParameter("HizmetNo", hizmetNo) :
                new ObjectParameter("HizmetNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("HSil", hizmetNoParameter);
        }
    
        public virtual int MEkle(string musteriAdSoyad, string musteriCinsiyet, string musteriTelefon, string musteriTcNo, string musteriAdres, Nullable<int> musteriHizmetNo, string musteriMail)
        {
            var musteriAdSoyadParameter = musteriAdSoyad != null ?
                new ObjectParameter("MusteriAdSoyad", musteriAdSoyad) :
                new ObjectParameter("MusteriAdSoyad", typeof(string));
    
            var musteriCinsiyetParameter = musteriCinsiyet != null ?
                new ObjectParameter("MusteriCinsiyet", musteriCinsiyet) :
                new ObjectParameter("MusteriCinsiyet", typeof(string));
    
            var musteriTelefonParameter = musteriTelefon != null ?
                new ObjectParameter("MusteriTelefon", musteriTelefon) :
                new ObjectParameter("MusteriTelefon", typeof(string));
    
            var musteriTcNoParameter = musteriTcNo != null ?
                new ObjectParameter("MusteriTcNo", musteriTcNo) :
                new ObjectParameter("MusteriTcNo", typeof(string));
    
            var musteriAdresParameter = musteriAdres != null ?
                new ObjectParameter("MusteriAdres", musteriAdres) :
                new ObjectParameter("MusteriAdres", typeof(string));
    
            var musteriHizmetNoParameter = musteriHizmetNo.HasValue ?
                new ObjectParameter("MusteriHizmetNo", musteriHizmetNo) :
                new ObjectParameter("MusteriHizmetNo", typeof(int));
    
            var musteriMailParameter = musteriMail != null ?
                new ObjectParameter("MusteriMail", musteriMail) :
                new ObjectParameter("MusteriMail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MEkle", musteriAdSoyadParameter, musteriCinsiyetParameter, musteriTelefonParameter, musteriTcNoParameter, musteriAdresParameter, musteriHizmetNoParameter, musteriMailParameter);
        }
    
        public virtual int MG(Nullable<int> musteriNo, string musteriAdSoyad, string musteriCinsiyet, string musteriTelefon, string musteriTcNo, string musteriAdres, Nullable<int> musteriHizmetNo, string musteriMail)
        {
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("MusteriNo", musteriNo) :
                new ObjectParameter("MusteriNo", typeof(int));
    
            var musteriAdSoyadParameter = musteriAdSoyad != null ?
                new ObjectParameter("MusteriAdSoyad", musteriAdSoyad) :
                new ObjectParameter("MusteriAdSoyad", typeof(string));
    
            var musteriCinsiyetParameter = musteriCinsiyet != null ?
                new ObjectParameter("MusteriCinsiyet", musteriCinsiyet) :
                new ObjectParameter("MusteriCinsiyet", typeof(string));
    
            var musteriTelefonParameter = musteriTelefon != null ?
                new ObjectParameter("MusteriTelefon", musteriTelefon) :
                new ObjectParameter("MusteriTelefon", typeof(string));
    
            var musteriTcNoParameter = musteriTcNo != null ?
                new ObjectParameter("MusteriTcNo", musteriTcNo) :
                new ObjectParameter("MusteriTcNo", typeof(string));
    
            var musteriAdresParameter = musteriAdres != null ?
                new ObjectParameter("MusteriAdres", musteriAdres) :
                new ObjectParameter("MusteriAdres", typeof(string));
    
            var musteriHizmetNoParameter = musteriHizmetNo.HasValue ?
                new ObjectParameter("MusteriHizmetNo", musteriHizmetNo) :
                new ObjectParameter("MusteriHizmetNo", typeof(int));
    
            var musteriMailParameter = musteriMail != null ?
                new ObjectParameter("MusteriMail", musteriMail) :
                new ObjectParameter("MusteriMail", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MG", musteriNoParameter, musteriAdSoyadParameter, musteriCinsiyetParameter, musteriTelefonParameter, musteriTcNoParameter, musteriAdresParameter, musteriHizmetNoParameter, musteriMailParameter);
        }
    
        public virtual ObjectResult<MGor_Result> MGor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MGor_Result>("MGor");
        }
    
        public virtual int MSil(Nullable<int> musteriNo)
        {
            var musteriNoParameter = musteriNo.HasValue ?
                new ObjectParameter("MusteriNo", musteriNo) :
                new ObjectParameter("MusteriNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MSil", musteriNoParameter);
        }
    
        public virtual int SEkle(string siparisAdi, Nullable<int> siparisMusteriNo, string siparisAdres, string siparisAciklama)
        {
            var siparisAdiParameter = siparisAdi != null ?
                new ObjectParameter("SiparisAdi", siparisAdi) :
                new ObjectParameter("SiparisAdi", typeof(string));
    
            var siparisMusteriNoParameter = siparisMusteriNo.HasValue ?
                new ObjectParameter("SiparisMusteriNo", siparisMusteriNo) :
                new ObjectParameter("SiparisMusteriNo", typeof(int));
    
            var siparisAdresParameter = siparisAdres != null ?
                new ObjectParameter("SiparisAdres", siparisAdres) :
                new ObjectParameter("SiparisAdres", typeof(string));
    
            var siparisAciklamaParameter = siparisAciklama != null ?
                new ObjectParameter("SiparisAciklama", siparisAciklama) :
                new ObjectParameter("SiparisAciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SEkle", siparisAdiParameter, siparisMusteriNoParameter, siparisAdresParameter, siparisAciklamaParameter);
        }
    
        public virtual int SG(Nullable<int> siparisNo, string siparisAdi, Nullable<int> siparisMusteriNo, string siparisAdres, string siparisAciklama)
        {
            var siparisNoParameter = siparisNo.HasValue ?
                new ObjectParameter("SiparisNo", siparisNo) :
                new ObjectParameter("SiparisNo", typeof(int));
    
            var siparisAdiParameter = siparisAdi != null ?
                new ObjectParameter("SiparisAdi", siparisAdi) :
                new ObjectParameter("SiparisAdi", typeof(string));
    
            var siparisMusteriNoParameter = siparisMusteriNo.HasValue ?
                new ObjectParameter("SiparisMusteriNo", siparisMusteriNo) :
                new ObjectParameter("SiparisMusteriNo", typeof(int));
    
            var siparisAdresParameter = siparisAdres != null ?
                new ObjectParameter("SiparisAdres", siparisAdres) :
                new ObjectParameter("SiparisAdres", typeof(string));
    
            var siparisAciklamaParameter = siparisAciklama != null ?
                new ObjectParameter("SiparisAciklama", siparisAciklama) :
                new ObjectParameter("SiparisAciklama", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SG", siparisNoParameter, siparisAdiParameter, siparisMusteriNoParameter, siparisAdresParameter, siparisAciklamaParameter);
        }
    
        public virtual ObjectResult<SGor_Result> SGor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SGor_Result>("SGor");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int SSil(Nullable<int> siparisNo)
        {
            var siparisNoParameter = siparisNo.HasValue ?
                new ObjectParameter("SiparisNo", siparisNo) :
                new ObjectParameter("SiparisNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SSil", siparisNoParameter);
        }
    
        public virtual ObjectResult<HArama_Result> HArama(Nullable<int> hizmetNo)
        {
            var hizmetNoParameter = hizmetNo.HasValue ?
                new ObjectParameter("HizmetNo", hizmetNo) :
                new ObjectParameter("HizmetNo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<HArama_Result>("HArama", hizmetNoParameter);
        }
    }
}
