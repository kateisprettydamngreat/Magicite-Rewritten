using System;

namespace Steamworks;

[Flags]
public enum EAppOwernshipFlags
{
	k_EAppOwernshipFlags_None = 0,
	k_EAppOwernshipFlags_OwnsLicense = 1,
	k_EAppOwernshipFlags_FreeLicense = 2,
	k_EAppOwernshipFlags_RegionRestricted = 4,
	k_EAppOwernshipFlags_LowViolence = 8,
	k_EAppOwernshipFlags_InvalidPlatform = 0x10,
	k_EAppOwernshipFlags_SharedLicense = 0x20,
	k_EAppOwernshipFlags_FreeWeekend = 0x40,
	k_EAppOwernshipFlags_LicenseLocked = 0x80,
	k_EAppOwernshipFlags_LicensePending = 0x100,
	k_EAppOwernshipFlags_LicenseExpired = 0x200
}
