/*
 * PROPRIETARY INFORMATION.  This software is proprietary to
 * Side Effects Software Inc., and is not to be reproduced,
 * transmitted, or disclosed in any way without written permission.
 *
 * Produced by:
 *      Side Effects Software Inc
 *      123 Front Street West, Suite 1401
 *      Toronto, Ontario
 *      Canada   M5J 2M2
 *      416-504-9876
 *
 * COMMENTS:
 *      Generated version information to be used when linking for sanity checks.
 */

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// WARNING! This file is GENERATED by Make.
// DO NOT modify manually or commit to the repository!
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Versions

public struct HoudiniVersion
{
	public const int HOUDINI_MAJOR			= 16;
	public const int HOUDINI_MINOR			= 5;
	public const int HOUDINI_BUILD			= 460;
	public const int HOUDINI_PATCH			= 0;

	public const int HOUDINI_ENGINE_MAJOR	= 3;
	public const int HOUDINI_ENGINE_MINOR	= 1;

	public const int HOUDINI_ENGINE_API		= 13;

#if UNITY_EDITOR_WIN || ( UNITY_METRO && UNITY_EDITOR )

	public const string HAPI_SERVER			= "HARS.exe";
	#if UNITY_EDITOR_64 || UNITY_64
		public const string HAPI_LIBRARY	= "libHARC";
	#else
		public const string HAPI_LIBRARY	= "libHARC32";
	#endif // UNITY_EDITOR_64

#elif UNITY_EDITOR_OSX

	public const string HAPI_SERVER			= "/Applications/Houdini/Houdini16.5.460/Frameworks/Houdini.framework/Versions/16.5.460/Resources/bin/" + "HARS";
	#if UNITY_EDITOR_64 || UNITY_64
		public const string HAPI_LIBRARY	= "/Applications/Houdini/Houdini16.5.460/Frameworks/Houdini.framework/Versions/16.5.460/Libraries/" + "libHARC.dylib";
	#else
		public const string HAPI_LIBRARY	= "/Applications/Houdini/Houdini16.5.460/Frameworks/Houdini.framework/Versions/16.5.460/Libraries/" + "libHARC32.dylib";
	#endif // UNITY_EDITOR_64

#elif UNITY_STANDALONE_LINUX

	public const string HAPI_SERVER			= "/opt/hfs16.5.460/bin/" + "HARS";
	public const string HAPI_LIBRARY		= "/opt/hfs16.5.460/dsolib/" + "libHARC.so";

#else

	public const string HAPI_LIBRARY		= "libHAPI"; // Cannot be empty but its ok if not found.

#endif
};
