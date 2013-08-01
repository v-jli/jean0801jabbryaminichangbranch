namespace JabbR.Models.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class SeparateAfkNote : IDbMigrationMetadata
    {
        string IDbMigrationMetadata.Id
        {
            get { return "201112221045208_SeparateAfkNote"; }
        }
        
        string IDbMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IDbMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}
