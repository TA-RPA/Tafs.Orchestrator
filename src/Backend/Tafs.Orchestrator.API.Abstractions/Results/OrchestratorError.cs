﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tafs.Orchestrator.API.Abstractions.Results
{
    /// <summary>
    /// Enumerates the various Orchestrator error codes.
    /// </summary>
    public enum OrchestratorError
    {
        Unknown,
        MultipleErrors,
        InvalidODataRequest,
        InvalidRequest,
        NameAlreadyUsed,
        ItemNotFound,
        StringProtectFailed,
        ItemAlreadyExists,
        ErrorDeleting,
        ErrorInserting,
        ErrorUpdating,
        ErrorSendingEmail,
        InvalidArgument,
        SqlAcquireLockFailure,
        LibrariesFeedInUse,
        HasDependentItems,
        ItemIsInUse,
        ParameterMissing,
        ParameterInvalid,
        DuplicateReference,
        ForbiddenOperation,
        InvalidUser,
        FeatureDisabled,
        OptimisticConcurrency,
        EncryptionException,
        CannotCreateOrMigrateTenantDb,
        TenantIsRequired,
        FieldNotEditable,
        ServiceUnavailable,
        SharedAccessSignatureFailure,
        ProviderNotSupported,
        EmailAlreadyUsed,
        MaxSiblingsLimitReached,
        InvalidAuditRelationship,
        InvalidOrganizationUnit,
        RequiredOrganizationUnit,
        OrganizationUnitNotEditable,
        NoOrganizationUnitWithPermissions,
        MultipleOrganizationUnitsOnSession,
        InvalidPermissionInCrossFolderRequest,
        CannotCreateClassicEntities,
        CannotEditClassicEntities,
        RequiredPermissions,
        CannotEditDuringMigration,
        MachineAlreadyPairedWithDifferentLicenseKey,
        NoAvailableLicenses,
        HasAttachedRobots,
        InvalidMachineKey,
        MachineNameRequired,
        UserNameRequired,
        CannotDeleteBusyRobot,
        MachineNameCannotChange,
        MachineLicenseCannotChange,
        CannotUpdateBusyRobot,
        MachineTypeCannotChange,
        UserNameInvalid,
        SessionAlreadyActive,
        CannotAssignMachineToFloatingRobot,
        CannotUpdateRobotHostingType,
        CannotAssignMachineTemplateToStandardRobot,
        CannotUpdateActiveSession,
        MachineTemplateUniqueLicenseKey,
        InvalidMachineId,
        InvalidNonProductionMachineSlots,
        InvalidUnattendedMachineSlots,
        DisconnectedRobot,
        UnresponsiveRobot,
        UnsupportedFloatingSessionRobotType,
        UnsupportedStandardSessionRobotType,
        RobotNotFoundUseInteractive,
        MachineScopeProtected,
        MachineKeyCannotChange,
        TenantIdMismatch,
        UserDoesNotHaveRobot,
        NoDefaultAutoScalingProfile,
        InvalidAutoScalingProfileSchedule,
        CannotPropagateMachineToSubfolders,
        MachineRuntimeProtected,
        IncompatibleOS,
        IncompatibleRobotVersion,
        MachineMaintenanceWindowDuration,
        MachineMaintenanceTimeZoneId,
        ClassicRobotNotFound,
        ClassicRobotToUserMappingUsernameMissmatch,
        UserMappedToRobotWithDifferentUsername,
        RobotOnDifferentMachineMappedToSameUser,
        ClassicRobotMappedToInvalidUser,
        SameRobotUsernameMappedToDiferentUser,
        ClassicCannotCleanNotFailedMigrations,
        InvalidSlots,
        InvalidJobKey,
        MachineSessionNotFound,
        EnvironmentDeploymentConflict,
        ServerConflict,
        ActionAlreadyPerformed,
        UnavailableResources,
        UserIsDeleted,
        UserIsLockedOut,
        ChangePassword,
        PasswordExpired,
        InvalidPassword,
        CannotDeleteStaticRole,
        UserNotEditable,
        DomainUnreachable,
        PasswordResetFailed,
        ConfirmEmailFailed,
        CannotUsePreviousPassword,
        RoleIsNotEditable,
        UserNotFoundInDomain,
        CannotUpdateUsername,
        InvalidLoginMethod,
        InvalidUsernameOrPassword,
        MultipleMatchingUsers,
        CannotCallFromHost,
        CreateNotAllowed,
        ProvisionError,
        EmptyDirectoryParam,
        NotDirectoryUserOrGroup,
        NoUsersFound,
        CannotChangeRoleType,
        InvalidTenantRole,
        InvalidFolderRole,
        HostTenantKeyNotFound,
        CannotAssignFolderRolesToUser,
        CannotAssignTenantRolesToFolder,
        InvalidAuthenticationToken,
        CannotDeleteLastAdmin,
        CannotUnassignLastAdmin,
        CannotInactivateLastAdmin,
        UserNotInRole,
        UserAlreadyInRole,
        AdditionalPermissionsNotAllowed,
        CredentialAssetEmptyPasswordForNewUser,
        CredentialAssetEmptyForNewRobot,
        AssetTypeNonUpdatable,
        AssetNotAvailableForRobot,
        AssetNotFound,
        InvalidCron,
        ScheduleWillNeverRun,
        ScheduleMisfired,
        InvalidScheduleKey,
        ScheduleIsNotEnabled,
        ScheduleNotAssociatedWithAQueue,
        ScheduleCannotBeAssociatedWithAQueue,
        UserIsAssignedToTriggers,
        InvalidCronRecurrence,
        DisabledDueToConsecutiveFailures,
        MachineRobotHasAttachedTriggers,
        UserHasAttachedTriggers,
        MachineHasAttachedTriggers,
        InvalidTimeZoneId,
        DownloadUnavailable,
        CannotConnectToPackagesRepository,
        NotSupportedByExternalFeeds,
        ErrorDownloading,
        InvalidPackageDetails,
        TenantFeedInUse,
        InvalidProcessKey,
        JobTypeCannotBeStopped,
        JobCannotBeCancelled,
        JobCannotBeTerminated,
        VersionNotFound,
        ProcessNotFound,
        HasAttachedProcesses,
        InvalidExtension,
        InvalidPackageCount,
        PreviousVersionNotFound,
        HasRunningJobs,
        TenantNotFound,
        PendingJobsAlreadyExist,
        InvalidStartJobRobotIds,
        UnregisteredCannotStartJobs,
        LicenseExpiredCannotStartJobs,
        InvalidReleaseKey,
        InvalidPackageVersion,
        TenantIsDisabled,
        PackageNotFound,
        NoRobotsAvailable,
        PathTooLong,
        JobExecutionFaulted,
        InvalidJobIdOrRobotKey,
        InvalidJobStateForSuspend,
        JobNotFoundByPersistenceId,
        SuspendJobStateNotFound,
        ErrorPackagePublish,
        ErrorSavingPackageDefinition,
        MaxNumberJobsAlreadyExist,
        HasSlaEnabedQueuesAssociated,
        VersionsManagedAutomatically,
        InaccessibleFeed,
        TestAutomationJobExecutionNotSupported,
        TestAutomationProcessAlreadyExists,
        CannotRestartUnfinishedJob,
        CyberArkEditPasswordNotAllowed,
        LogMessageNotFound,
        LogRobotNameNotFound,
        EncryptionKeyNotFound,
        EncryptionKeyIncorrectFormat,
        AzureKeyVaultRetrieveIssue,
        AzureKeyVaultStoreIssue,
        EncryptionKeyUnavailable,
        TransactionReferenceRequired,
        InvalidTransactionProgressStatus,
        TransactionNotStarted,
        ReviewerNotAvailable,
        QueueDefinitionParametersCannotChange,
        QueueProcessingApplicationException,
        QueueItemSchemaViolationException,
        InvalidQueueSchemaDefinition,
        InvalidQueueSchemaDefinitionChange,
        InvalidQueueSchemaType,
        QueueSchemaDefinitionNotFound,
        SlaEnableQueueDefinitionFailure,
        QueueSlaAtPredictedRisk,
        QueueSlaPredictedBreach,
        QueueItemContentSizeExceeded,
        QueueItemInvalidTransitionFromFinalStatus,
        LicenseNotFound,
        LicenseExpired,
        LicenseAlreadyInUse,
        InvalidLicenseFormat,
        LicenseLimitExceeded,
        UnattendedLicenseLimitExceeded,
        NonProductionLicenseLimitExceeded,
        AttendedLicenseLimitExceeded,
        DevelopmentLicenseLimitExceeded,
        RobotFailedToAcquireLicense,
        NonProductionSlotsLimitExceeded,
        UnattendedSlotsLimitExceeded,
        LicenseUnregistered,
        LicenseNotAvailable,
        NotEnoughAvailableSlots,
        NotEnoughRuntimeLicenses,
        SlotsExceedLicenseLimit,
        NotEnoughAvailableLicenses,
        HostLicenseLimitExceeded,
        NoHostLicense,
        LicenseNewInvalidArguments,
        LicenseMachineDisabled,
        CannotDisableBusyMachine,
        HeadlessSlotsLimitExceeded,
        HeadlessLicenseLimitExceeded,
        TestAutomationSlotsLimitExceeded,
        TestAutomationLicenseLimitExceeded,
        LicenseNotCompatible,
        AutomationCloudLicenseLimitExceeded,
        AutomationExpressNotSupported,
        ArgumentMetadataExtract,
        ArgumentMetadataValidation,
        ArgumentDefinitionExtract,
        ArgumentValueExtract,
        ArgumentValidation,
        PackageMetadataExtract,
        PackageMetadataValidation,
        ProjectTypeChangedOnUpload,
        EntryPointUniqueIdsAlreadyUsed,
        EntryPointNotValidForRelease,
        EntryPointNotAllowedForTestAutomationRelease,
        UnknownWebhookEventType,
        WebhookQuotaReached,
        WebhookDuplicateName,
        ExecutionMediaStorageUnavailable,
        ExecutionMediaNotAvailableForJob,
        ExecutionMediaContentNotAvailable,
        JobNotAssignedToRobot,
        JobAssignedToDifferentRobot,
        JobNotCompleted,
        JobVideoRecordingNotEnabled,
        CannotDeleteDefaultCredentialStore,
        CredentialStoreNotFound,
        UnknownCredentialStoreType,
        InvalidCredentialStoreConfiguration,
        FailedToReadFromCredentialStore,
        FailedToWriteToCredentialStore,
        CannotDeleteNonEmptyCredentialStore,
        FailedToDeleteFromCredentialStore,
        TaskAssignmentError,
        TaskCompletionError,
        TaskAssigneeMismatchError,
        TaskFormInvalidFormLayout,
        TaskFormInvalidFormPayload,
        TaskFormMultipleActions,
        TaskFormNoAction,
        TaskFormInvalidAction,
        TasksNotAllowedInModernFolder,
        NoFolderExistAsTaskAdmin,
        NoFolderExistAsTaskUser,
        TaskAlreadyCompletedBySameUser,
        TaskTypeMistmatch,
        TaskNotAlreadyAssigned,
        TaskAssigneeNotPermitted,
        TaskAssignerNotPermitted,
        DuplicateTaskAssignment,
        TaskAlreadyAssignedToSameUser,
        TaskAlreadyAssignedToAnotherUser,
        TaskAlreadyCompletedByAnotherUser,
        TaskSaveError,
        TaskFormNoData,
        TaskForwardError,
        TaskFormSubmitButtonMissing,
        TaskDeletionGenericError,
        TaskAlreadyDeletedBySameUser,
        TaskAlreadyDeletedByAnotherUser,
        TaskDeleterNotPermitted,
        DuplicateTaskDelete,
        NoFolderExistsWithTaskCatalogView,
        TaskCatalogMultipleDistinctColumn,
        TaskCatalogDistinctColumnInvalid,
        TaskFormLayoutAndIdMissing,
        TaskFormDuplicateFormLayoutGuid,
        TaskFormFormLayoutGuidNotFound,
        TaskFormLayoutOrGuidMissing,
        TaskFormLayoutAndIdBothNotSupported,
        TaskFormLayoutIdNotFound,
        TaskFormLayoutOutOfSize,
        TaskCatalogHaveActiveTasks,
        TasksBulkFormLayoutIdsNotSameOrNull,
        EmptyTasksBulkOperationRequest,
        TaskMaximumBulkOperationLimitExceeded,
        TasksBulkOperationError,
        TasksBulkOperationInvalidCatalog,
        TasksBulkUpdateWithTaskCatalogAndUnsetIsInvalid,
        EditTaskNotFound,
        TasksEditMetadataWithTaskCatalogAndUnsetIsInvalid,
        TasksEditMetadataOperationInvalidCatalog,
        TasksEditMetadataCatalogInEncryptedTaskIsInvalid,
        TaskCatalogNotFound,
        TaskCatalogEncrypted,
        TasksSummaryDateDiffOutOfRange,
        TasksSummaryEndDateShouldBeGreater,
        TaskDefinitionPropertiesRequired,
        InvalidSecureStoreContext,
        MailSmtpSettingsError,
        CannotDeleteCalendarWhenUsedBySchedule,
        InvalidExternalUrl,
        HostMailSmtpSettingsError,
        MandatoryPropertiesForRootFolderNotSpecified,
        IncompatibleFolderProperties,
        NoHierarchyAllowedForClassicFolders,
        MaximumFolderHierarchyDepthReached,
        CannotChangeRobotProvisionType,
        CannotChangeFolderPermissionModel,
        CannotEditFolderParent,
        EntitiesRequiredForAssignmentNotFound,
        CannotAssignRolesToNonFineGrainedFolders,
        InvalidFolderDisplayName,
        AssociationAlreadyExists,
        UserDoesNotHaveAccessToFolder,
        CannotChangeRobotUserFolderAssignments,
        CannotAssignMachineToClassicFolder,
        StrategyNotAvailableInModernFolder,
        StrategyNotAvailableInClassicFolder,
        ValidModernFolderIdRequired,
        NoMachineAssociatedWithFolder,
        ClassicFoldersCannotBeInvolvedInMoveOperation,
        CannotMoveToDescendantFolder,
        CannotDisableTriggersInHierarchy,
        CannotKillJobsInHierarchy,
        CannotDeleteEntitiesInHierarchy,
        NotInFinalStateJobsExist,
        ModernFoldersCannotInheritRolesFromTenant,
        CannotChangeFolderFeedType,
        CannotCreatePersonalWorkspace,
        CannotSetMachineRobots,
        FolderNotFound,
        CannotUnassignFromFolder,
        MachineAssociatedWithFolderConflict,
        CannotAssignMachineToFolder,
        CannotAssignPersonalWorkspaceMachines,
        CannotMoveFolder,
        CannotMigrateClassicRelatedObjects,
        NotSuccessfulEntityMigration,
        FolderTypeMismatch,
        ActionNotAllowedInClassicFolder,
        MaintenanceActive,
        TenantMaintenanceActive,
        TenantMaintenanceNotActive,
        AnalyticsNotAuthorized,
        AnalyticsTenantNotProvisioned,
        AnalyticsUserIsHostUser,
        AnalyticsUserHasNoEmail,
        AnalyticsUserNotFound,
        AnalyticsAdminEmailProhibited,
        AnalyticsDbQueryFailure,
        InvalidStorageProvider,
        BucketIsReadOnly,
        InvalidBlobFilePath,
        UnavailableStorageProvider,
        BucketDoesNotExists,
        BucketSecretNotFoundInCredentialStore,
        TestSetNotNewOnCreate,
        TestAutomationKeyMismatch,
        TestSetNewOnUpdate,
        TestSetEmpty,
        TestSetDuplicatePackages,
        TestSetVersionMaskInvalid,
        TestSetDefinitionNotFound,
        TestSetTestCaseInvalid,
        TestSetTestCaseVersionInvalid,
        TestAutomationVersionInvalid,
        TestSetExecutionEmptyTestSet,
        TestSetExecutionCreateFailed,
        TestSetExecutionDuplicateUniqueIds,
        TestCaseAssertionScreenshotMimeTypeMissing,
        TestCaseAssertionScreenshotMissing,
        TestSetExecutionBatchExecutionKeyAlreadyExists,
        TestDataQueueContentJsonSchemaInvalid,
        TestDataQueueNameChangeNotAllowed,
        TestDataQueueItemViolatesContentJsonSchema,
        TestDataQueueItemsFromMultipleQueues,
        TestDataQueueItemsBulkAddMixed,
        TestDataQueueBulkOperationInProgress,
        TestSetDuplicateInputArgument,
        TestSetExecutionInvalidExecutionTarget,
        AttachmentInvalid,
        TestCasesReexecuteFailed,
        TestSetTestCaseMissingReleaseVersion,
        TestCaseDefinitionDuplicateIds,
        TestCaseDefinitionInUse,
        TestSetScheduleInvalidScheduleKey,
        InvalidTenantMoveStatus,
        TenantMoveIdConflict,
        TenantMoveMigrationConflict,
        MediaFileNotFound,
        MediaFileNotFoundForKey,
        InvalidMediaFilesUpload,
        MediaFileTypeNotSupported,
        CannotBeExploredByOwner,
        AlreadyExploredByCurrentUser,
        NotExploredCurrentUser,
        CannotRemoveMachineFromPersonalWorkspace,
        CannotToggleDebugMode,
        CannotStartRemoteControl,
        CannotStopRemoteControl,
        CheckForUpdatesWithProductDuplicates,
        AccountIdMissing,
        AccountIdPartitionKeyMismatch,
        IdentityKeyMissing,
        InvalidDownloadUri,
        InstallationIdMissing,
        UpdateRequestRetryFailed,
        InvalidProductVersion,
        ProductVersionUpdateNotAllowed,
        HostRetentionPolicyInvalidLicenseType,
        TenantRetentionPolicyLicenseTypeNotSupported,
        SWRobotCreationFailed,
        SWRobotCreationNotEnabled,
        SWPersonalWorkspaceCreationFailed,
        SWPersonalWorkspacesNotEnabled,
        SWMachineTemplateCreationFailed,
        SWMachineTemplateAssignmentFailed,
        SWMachineTemplateAssignmentMissingVirtualFolder,
        SWRobotCreationNoLicense,
        SWUserDoesNotHaveAnAttendedRobotOrProvisionNotEnabled,
        SWUserInactive,
        SWUserLicensingEnabledNoRobots,
        SWUserLicensingEnabledRobotProvisionFailed,
        SWUserLicensingEnabledAttendedLicense,
        SWUserLicensingDisabledNoRobots,
        SWUserLicensingDisabledRobotProvisionFailed,
        SWUserLicensingDisabledAttendedLicense,
        ConnectionsAvailableOnlyInPW,
        ResourceOverwriteNotSupported,
        ResourceNotOverwritable,
        ResourceOverwriteNotSupportedInStandardFolders,
        MultipleOverwritesForSameResourceKeyNotSupported,
        PackageResourceNotFound,
        InvalidConnectionId,
        ConnectionNotFound,
        InvalidConnectionType,
        ConnectedEventTriggerNoConnection,
        ConnectedEventTriggerCreateFailed,
        ConnectedEventTriggerDeleteFailed,
        MissingEventTriggerBinding,
        VirtualTriggerCanNotHaveUser,
        EventTriggerCreateFailedConnectionNotAvailable,
        UserHasNoRobotToFireUserEventTrigger,
        CredentialsProxyNotFound,
        CannotDeleteCredentialsProxyInUse,
        CredentialsProxyUrlMustBeHttps,
        CredentialsProxyHostUrlUpdateRequiresSecretResubmission,
        CredentialsProxyBadSecretFormat,
        CredentialsProxyAuthHealthRequestFailed,
        CredentialsProxyHealthRequestFailed,
        CredentialsProxyRequestFailedInvalidCredentials,
        CredentialsProxyConnectionRefused,
        ServerlessCreateMachineTemplateErrorCode,
        ServerlessUpdateMachineTemplateErrorCode,
        ServerlessDeleteMachineTemplateErrorCode,
        ServerlessUnkownActionMachineTemplateErrorCode,
        ServerlessVpnInvalidCidr,
        ServerlessVpnInvalidState,
        ServerlessVpnNotFound,
        ServerlessUnknownError,
        ServerlessNoMachineTemplate,
        ServerlessGenericWorkloadsNotEnabled,
        ServerlessRobotJobTypeInvalid,
        ServerlessServiceIsDisabledInTenant,
        InvalidSolutionArchive,
        CompatibilityCheckFail,
        RollbackNotSupported,
        SolutionsResourceNotFound,
        SolutionsResourceNotSupported,
        SolutionsResourcesNotFound,
        ExportTimeout,
        InvalidMessageReceived,
        ContentLengthTooLarge
    }
}
