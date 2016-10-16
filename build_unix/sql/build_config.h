
/*
** Build options detected by SQLite's configure script but not normally part
** of config.h.  Accept what configure detected unless it was overridden on the
** command line.
*/
#ifndef HAVE_EDITLINE
#define HAVE_EDITLINE 0
#endif
#if !HAVE_EDITLINE
#undef HAVE_EDITLINE
#endif

#ifndef HAVE_READLINE
#define HAVE_READLINE 0
#endif
#if !HAVE_READLINE
#undef HAVE_READLINE
#endif

#ifndef SQLITE_OS_UNIX
#define SQLITE_OS_UNIX 1
#endif
#if !SQLITE_OS_UNIX
#undef SQLITE_OS_UNIX
#endif

#ifndef SQLITE_OS_WIN
#define SQLITE_OS_WIN 0
#endif
#if !SQLITE_OS_WIN
#undef SQLITE_OS_WIN
#endif

#ifndef SQLITE_THREADSAFE
#define SQLITE_THREADSAFE 1
#endif
#if !SQLITE_THREADSAVE
#undef SQLITE_THREADSAVE
#endif

#ifndef SQLITE_TEMP_STORE
#define SQLITE_TEMP_STORE 1
#endif
#if !SQLITE_TEMP_STORE
#undef SQLITE_TEMP_STORE
#endif
