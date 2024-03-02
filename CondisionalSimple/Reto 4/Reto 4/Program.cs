SQLite format 3   @     J   3                                                            J .f�   �    ��K
�	��Q��RJ                                                                                                                                                                                                                                                                                                                                                                                                                                                                       �$W-�QindexSymbolDefinition_DefiningFileId_IndexSymbolDefinitionCREATE INDEX [SymbolDefinition_DefiningFileId_Index]
    ON [SymbolDefinition] ([DefiningFileId])�C-�GindexSymbolDefinition_Name_IndexSymbolDefinitionCREATE INDEX [SymbolDefinition_Name_Index]
    ON [SymbolDefinition] ([Name] COLLATE NOCASE)�=--�-tableSymbolDefinitionSymbolDefinitionCREATE TABLE [SymbolDefinition]
(
    [SymbolDefinitionId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    [ProviderId] INTEGER NOT NULL
        REFERENCES [ProviderEntity]([ProviderId])
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    [Name] NVARCHAR(255) NOT NULL COLLATE NOCASE,
    [FullyQualifiedName] NVARCHAR(255) COLLATE NOCASE,
    [Kind] INTEGER NOT NULL,
    [Accessibility] INTEGER NOT NULL,
    [DefiningFileId] INTEGER NOT NULL
        REFERENCES [FileSystemEntity]([FileSystemEntityId]) 
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    [LocationRow] INTEGER NOT NULL,
    [LocationColumn] INTEGER NOT NULL
)�/_-�_indexFileScannerCache_FileSystemEntityId_IndexFileScannerCacheCREATE INDEX [FileScannerCache_FileSystemEntityId_Index]
    ON [FileScannerCache]([FileSystemEntityId])�U
--�]tableFileScannerCacheFileScannerCacheCREATE TABLE [FileScannerCache]
(
    [FileScannerCacheId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
    [FileSystemEntityId] INTEGER NOT NULL REFERENCES [FileSystemEntity]([FileSystemEntityId])
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    [ProviderId] INTEGER NOT NULL REFERENCES [ProviderEntity]([ProviderId])
        ON DELETE CASCADE,
    [Type] INTEGER NOT NULL,
    [Timestamp] DATETIME NULL
)�-	/)�indexProviderType_TypeProviderEntity
CREATE UNIQUE INDEX [ProviderType_Type]
    ON [ProviderEntity] ([ProviderType] COLLATE NOCASE,[ProviderVersion] COLLATE NOCASE)� ))�;tableProviderEntityProviderEntity	CREATE TABLE [ProviderEntity]
(
    [ProviderId] INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    [ProviderType] NVARCHAR(20) NOT NULL COLLATE NOCASE,
    [ProviderVersion] NVARCHAR(20) NOT NULL COLLATE NOCASE
)�:E-�indexFileSystemEntity_Parent_NameFileSystemEntityCREATE UNIQUE INDEX [FileSystemEntity_Parent_Name]
    ON [FileSystemEntity] ([Name] COLLATE NOCASE, [ParentFileSystemEntityId])�Bk-�yindexFileSystemEntity_ParentFileSystemEntityId_IndexFileSystemEntityCREATE INDEX [FileSystemEntity_ParentFileSystemEntityId_Index]
    ON [FileSystemEntity] ([ParentFileSystemEntityId])�C-�GindexFile