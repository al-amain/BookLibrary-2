﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.18444
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bibliotheque.Proxies
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="COUCHEIFAC/ClsIFACGestion_Bibliotheque", ConfigurationName="Bibliotheque.Proxies.ClsIFACGestion_Bibliotheque")]
    public interface ClsIFACGestion_Bibliotheque
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACGestion_Bibliotheque/ClsIFACGestion_Bibliotheque/SelectAllGesti" +
            "onnaireBiblio", ReplyAction="COUCHEIFAC/ClsIFACGestion_Bibliotheque/ClsIFACGestion_Bibliotheque/SelectAllGesti" +
            "onnaireBiblioResponse")]
        System.Collections.Generic.List<COUCHEBO.ClsBOGestion_Bibliotheque> SelectAllGestionnaireBiblio();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACGestion_Bibliotheque/ClsIFACGestion_Bibliotheque/SelectAllGesti" +
            "onnaireBiblio", ReplyAction="COUCHEIFAC/ClsIFACGestion_Bibliotheque/ClsIFACGestion_Bibliotheque/SelectAllGesti" +
            "onnaireBiblioResponse")]
        System.IAsyncResult BeginSelectAllGestionnaireBiblio(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<COUCHEBO.ClsBOGestion_Bibliotheque> EndSelectAllGestionnaireBiblio(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="COUCHEIFAC/ClsIFACGestion_Bibliotheque/ClsIFACGestion_Bibliotheque/SelectWhereIsA" +
            "dmin", ReplyAction="COUCHEIFAC/ClsIFACGestion_Bibliotheque/ClsIFACGestion_Bibliotheque/SelectWhereIsA" +
            "dminResponse")]
        COUCHEBO.ClsBOGestion_Bibliotheque SelectWhereIsAdmin(int Lecteur_ID, int Biblio_ID);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="COUCHEIFAC/ClsIFACGestion_Bibliotheque/ClsIFACGestion_Bibliotheque/SelectWhereIsA" +
            "dmin", ReplyAction="COUCHEIFAC/ClsIFACGestion_Bibliotheque/ClsIFACGestion_Bibliotheque/SelectWhereIsA" +
            "dminResponse")]
        System.IAsyncResult BeginSelectWhereIsAdmin(int Lecteur_ID, int Biblio_ID, System.AsyncCallback callback, object asyncState);
        
        COUCHEBO.ClsBOGestion_Bibliotheque EndSelectWhereIsAdmin(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ClsIFACGestion_BibliothequeChannel : Bibliotheque.Proxies.ClsIFACGestion_Bibliotheque, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ClsIFACGestion_BibliothequeClient : System.ServiceModel.ClientBase<Bibliotheque.Proxies.ClsIFACGestion_Bibliotheque>, Bibliotheque.Proxies.ClsIFACGestion_Bibliotheque
    {
        
        public ClsIFACGestion_BibliothequeClient()
        {
        }
        
        public ClsIFACGestion_BibliothequeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ClsIFACGestion_BibliothequeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ClsIFACGestion_BibliothequeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ClsIFACGestion_BibliothequeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOGestion_Bibliotheque> SelectAllGestionnaireBiblio()
        {
            return base.Channel.SelectAllGestionnaireBiblio();
        }
        
        public System.IAsyncResult BeginSelectAllGestionnaireBiblio(System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectAllGestionnaireBiblio(callback, asyncState);
        }
        
        public System.Collections.Generic.List<COUCHEBO.ClsBOGestion_Bibliotheque> EndSelectAllGestionnaireBiblio(System.IAsyncResult result)
        {
            return base.Channel.EndSelectAllGestionnaireBiblio(result);
        }
        
        public COUCHEBO.ClsBOGestion_Bibliotheque SelectWhereIsAdmin(int Lecteur_ID, int Biblio_ID)
        {
            return base.Channel.SelectWhereIsAdmin(Lecteur_ID, Biblio_ID);
        }
        
        public System.IAsyncResult BeginSelectWhereIsAdmin(int Lecteur_ID, int Biblio_ID, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSelectWhereIsAdmin(Lecteur_ID, Biblio_ID, callback, asyncState);
        }
        
        public COUCHEBO.ClsBOGestion_Bibliotheque EndSelectWhereIsAdmin(System.IAsyncResult result)
        {
            return base.Channel.EndSelectWhereIsAdmin(result);
        }
    }
}
