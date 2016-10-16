//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.7
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace BerkeleyDB.Internal {

using global::System;
using global::System.Runtime.InteropServices;

internal class DB : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal DB(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(DB obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose()  {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
} 

	internal DatabaseEntry[] get_partition_keys() {
		uint count = 0;
		int err = 0;
		uint size = 0;
		DatabaseEntry[] ret = get_partition_keys(ref count, ref size, ref err);
		DatabaseException.ThrowException(err);
		return ret;
	}
	internal DBC cursor(DB_TXN txn, uint flags) {
		int err = 0;
		DBC ret = cursor(txn, flags, ref err);
		DatabaseException.ThrowException(err);
		return ret;
	}
	
	internal DBC join(IntPtr[] curslist, uint flags) {
		int err = 0;
		DBC ret = join(curslist, flags, ref err);
		DatabaseException.ThrowException(err);
		return ret;
	}

	internal BTreeStatStruct stat_bt(DB_TXN txn, uint flags) {
		int err = 0;
		IntPtr ptr = stat(txn, flags, ref err);
		DatabaseException.ThrowException(err);
		BTreeStatStruct ret = (BTreeStatStruct)Marshal.PtrToStructure(ptr, typeof(BTreeStatStruct));
		libdb_csharp.__os_ufree(null, ptr);
		return ret;
	}
	internal HashStatStruct stat_hash(DB_TXN txn, uint flags) {
		int err = 0;
		IntPtr ptr = stat(txn, flags, ref err);
		DatabaseException.ThrowException(err);
		HashStatStruct ret = (HashStatStruct)Marshal.PtrToStructure(ptr, typeof(HashStatStruct));
		libdb_csharp.__os_ufree(null, ptr);
		return ret;
	}
	internal HeapStatStruct stat_heap(DB_TXN txn, uint flags) {
		int err = 0;
		IntPtr ptr = stat(txn, flags, ref err);
		DatabaseException.ThrowException(err);
		HeapStatStruct ret = (HeapStatStruct)Marshal.PtrToStructure(ptr, typeof(HeapStatStruct));
		libdb_csharp.__os_ufree(null, ptr);
		return ret;
	}
	internal QueueStatStruct stat_qam(DB_TXN txn, uint flags) {
		int err = 0;
		IntPtr ptr = stat(txn, flags, ref err);
		DatabaseException.ThrowException(err);
		QueueStatStruct ret = (QueueStatStruct)Marshal.PtrToStructure(ptr, typeof(QueueStatStruct));
		libdb_csharp.__os_ufree(null, ptr);
		return ret;
	}
	
	internal int get_blob_sub_dir(out string dir) {
		int ret;
		IntPtr dirp;
		ret = get_blob_sub_dir(out dirp);
		dir = Marshal.PtrToStringAnsi(dirp);
		return ret;
	}
	
	internal int get_dbname(out string filenamep, out string dbnamep) {
		int ret;
		IntPtr fp, dp;
		filenamep = dbnamep = null;
		ret = get_dbname(out fp, out dp);		
		filenamep = Marshal.PtrToStringAnsi(fp);
		dbnamep = Marshal.PtrToStringAnsi(dp);
		return ret;
	}

	internal int get_ext_file_dir(out string dir) {
		int ret;
		IntPtr dirp;
		ret = get_ext_file_dir(out dirp);
		dir = Marshal.PtrToStringAnsi(dirp);
		return ret;
	}
	
	internal int get_re_source(out string source) {
		int ret;
		IntPtr sp;
		ret = get_re_source(out sp);
		source = Marshal.PtrToStringAnsi(sp);		
		return ret;
	}

  internal BaseDatabase api_internal {
    set {
      libdb_csharpPINVOKE.DB_api_internal_set(swigCPtr, value);
    } 
		get { return libdb_csharpPINVOKE.DB_api_internal_get(swigCPtr); }
	
  }

  internal int set_usercopy(DBTCopyDelegate dbt_usercopy) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_usercopy(swigCPtr, dbt_usercopy);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal DB(DB_ENV env, uint flags) : this(libdb_csharpPINVOKE.new_DB(DB_ENV.getCPtr(env), flags), true) {
  }

  internal int associate(DB_TXN txn, DB sec, BDB_AssociateDelegate callback, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_associate(swigCPtr, DB_TXN.getCPtr(txn), DB.getCPtr(sec), callback, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int associate_foreign(DB dbp, BDB_AssociateForeignDelegate callback, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_associate_foreign(swigCPtr, DB.getCPtr(dbp), callback, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int close(uint flags) {
		int ret = libdb_csharpPINVOKE.DB_close(swigCPtr, flags);
		if (ret == 0)
			/* Close is a db handle destructor.  Reflect that in the wrapper class. */
			swigCPtr = new HandleRef(null, IntPtr.Zero);
		else
			DatabaseException.ThrowException(ret);
		return ret;
}

  internal int compact(DB_TXN txn, DatabaseEntry start, DatabaseEntry stop, DB_COMPACT cdata, uint flags, DatabaseEntry end) {
    try {
		int ret;
		ret = libdb_csharpPINVOKE.DB_compact(swigCPtr, DB_TXN.getCPtr(txn), DBT.getCPtr(DatabaseEntry.getDBT(start)), DBT.getCPtr(DatabaseEntry.getDBT(stop)), DB_COMPACT.getCPtr(cdata), flags, DBT.getCPtr(DatabaseEntry.getDBT(end)));
		DatabaseException.ThrowException(ret);
		return ret;
} finally {
      GC.KeepAlive(start);
      GC.KeepAlive(stop);
      GC.KeepAlive(end);
    }
  }

  private DBC cursor(DB_TXN txn, uint flags, ref int err) {
    global::System.IntPtr cPtr = libdb_csharpPINVOKE.DB_cursor(swigCPtr, DB_TXN.getCPtr(txn), flags, ref err);
    DBC ret = (cPtr == global::System.IntPtr.Zero) ? null : new DBC(cPtr, false);
    return ret;
  }

  internal int del(DB_TXN txn, DatabaseEntry key, uint flags) {
    try {
		int ret;
		ret = libdb_csharpPINVOKE.DB_del(swigCPtr, DB_TXN.getCPtr(txn), DBT.getCPtr(DatabaseEntry.getDBT(key)), flags);
		DatabaseException.ThrowException(ret);
		return ret;
} finally {
      GC.KeepAlive(key);
    }
  }

  internal DB_ENV env() {
    global::System.IntPtr cPtr = libdb_csharpPINVOKE.DB_env(swigCPtr);
    DB_ENV ret = (cPtr == global::System.IntPtr.Zero) ? null : new DB_ENV(cPtr, false);
    return ret;
  }

  internal int exists(DB_TXN txn, DatabaseEntry key, uint flags) {
    try {
		int ret;
		ret = libdb_csharpPINVOKE.DB_exists(swigCPtr, DB_TXN.getCPtr(txn), DBT.getCPtr(DatabaseEntry.getDBT(key)), flags);
		DatabaseException.ThrowException(ret);
		return ret;
} finally {
      GC.KeepAlive(key);
    }
  }

  internal int get(DB_TXN txn, DatabaseEntry key, DatabaseEntry data, uint flags) {
    try {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get(swigCPtr, DB_TXN.getCPtr(txn), DBT.getCPtr(DatabaseEntry.getDBT(key)), DBT.getCPtr(DatabaseEntry.getDBT(data)), flags);
		DatabaseException.ThrowException(ret);
		return ret;
} finally {
      GC.KeepAlive(key);
      GC.KeepAlive(data);
    }
  }

  internal int get_byteswapped(ref int isswapped) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_byteswapped(swigCPtr, ref isswapped);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_dbname(out IntPtr filenamep, out IntPtr dbnamep) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_dbname(swigCPtr, out filenamep, out dbnamep);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_multiple() {
		return libdb_csharpPINVOKE.DB_get_multiple(swigCPtr);
}

  internal int get_open_flags(ref uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_open_flags(swigCPtr, ref flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_transactional() {
		return libdb_csharpPINVOKE.DB_get_transactional(swigCPtr);
}

  internal int get_type(ref DBTYPE type) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_type(swigCPtr, ref type);
		DatabaseException.ThrowException(ret);
		return ret;
}

  private DBC join(IntPtr[] curslist, uint flags, ref int err) {
    global::System.IntPtr cPtr = libdb_csharpPINVOKE.DB_join(swigCPtr, curslist, flags, ref err);
    DBC ret = (cPtr == global::System.IntPtr.Zero) ? null : new DBC(cPtr, false);
    return ret;
  }

  internal int key_range(DB_TXN txn, DatabaseEntry key, DB_KEY_RANGE range, uint flags) {
    try {
		int ret;
		ret = libdb_csharpPINVOKE.DB_key_range(swigCPtr, DB_TXN.getCPtr(txn), DBT.getCPtr(DatabaseEntry.getDBT(key)), DB_KEY_RANGE.getCPtr(range), flags);
		DatabaseException.ThrowException(ret);
		return ret;
} finally {
      GC.KeepAlive(key);
    }
  }

  internal int open(DB_TXN txn, string file, string database, DBTYPE type, uint flags, int mode) {
	int ret;
	ret = libdb_csharpPINVOKE.DB_open(swigCPtr, DB_TXN.getCPtr(txn), file, database, (int)type, flags, mode);
	if (ret != 0)
		close(0);
	DatabaseException.ThrowException(ret);
	return ret;
}

  internal int pget(DB_TXN txn, DatabaseEntry key, DatabaseEntry pkey, DatabaseEntry data, uint flags) {
    try {
		int ret;
		ret = libdb_csharpPINVOKE.DB_pget(swigCPtr, DB_TXN.getCPtr(txn), DBT.getCPtr(DatabaseEntry.getDBT(key)), DBT.getCPtr(DatabaseEntry.getDBT(pkey)), DBT.getCPtr(DatabaseEntry.getDBT(data)), flags);
		DatabaseException.ThrowException(ret);
		return ret;
} finally {
      GC.KeepAlive(key);
      GC.KeepAlive(pkey);
      GC.KeepAlive(data);
    }
  }

  internal int put(DB_TXN txn, DatabaseEntry key, DatabaseEntry data, uint flags) {
    try {
		int ret;
		ret = libdb_csharpPINVOKE.DB_put(swigCPtr, DB_TXN.getCPtr(txn), DBT.getCPtr(DatabaseEntry.getDBT(key)), DBT.getCPtr(DatabaseEntry.getDBT(data)), flags);
		DatabaseException.ThrowException(ret);
		return ret;
} finally {
      GC.KeepAlive(key);
      GC.KeepAlive(data);
    }
  }

  internal int remove(string file, string database, uint flags) {
	int ret;
	ret = libdb_csharpPINVOKE.DB_remove(swigCPtr, file, database, flags);
	/* 
	 * remove is a handle destructor, regardless of whether the remove
	 * succeeds.  Reflect that in the wrapper class. 
	 */
	swigCPtr = new HandleRef(null, IntPtr.Zero);
	DatabaseException.ThrowException(ret);
	return ret;
}

  internal int rename(string file, string database, string newname, uint flags) {
	int ret;
	ret = libdb_csharpPINVOKE.DB_rename(swigCPtr, file, database, newname, flags);
	/* 
	 * rename is a handle destructor, regardless of whether the rename
	 * succeeds.  Reflect that in the wrapper class. 
	 */
	swigCPtr = new HandleRef(null, IntPtr.Zero);
	DatabaseException.ThrowException(ret);
	return ret;
}

  internal int set_append_recno(BDB_AppendRecnoDelegate callback) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_append_recno(swigCPtr, callback);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_blob_sub_dir(out IntPtr dir) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_blob_sub_dir(swigCPtr, out dir);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_bt_compare(BDB_CompareDelegate callback) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_bt_compare(swigCPtr, callback);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_bt_compress(BDB_CompressDelegate compress, BDB_DecompressDelegate decompress) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_bt_compress(swigCPtr, compress, decompress);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_bt_minkey(ref uint bt_minkey) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_bt_minkey(swigCPtr, ref bt_minkey);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_bt_minkey(uint bt_minkey) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_bt_minkey(swigCPtr, bt_minkey);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_bt_prefix(BDB_PrefixCompareDelegate callback) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_bt_prefix(swigCPtr, callback);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_cachesize(ref uint gbytes, ref uint bytes, ref int ncache) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_cachesize(swigCPtr, ref gbytes, ref bytes, ref ncache);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_cachesize(uint gbytes, uint bytes, int ncache) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_cachesize(swigCPtr, gbytes, bytes, ncache);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_dup_compare(BDB_CompareDelegate callback) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_dup_compare(swigCPtr, callback);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_encrypt_flags(ref uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_encrypt_flags(swigCPtr, ref flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_encrypt(string pwd, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_encrypt(swigCPtr, pwd, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal void set_errcall(BDB_ErrcallDelegate db_errcall_fcn) {
    libdb_csharpPINVOKE.DB_set_errcall(swigCPtr, db_errcall_fcn);
  }

  internal int get_ext_file_dir(out IntPtr dir) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_ext_file_dir(swigCPtr, out dir);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_ext_file_dir(string dir) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_ext_file_dir(swigCPtr, dir);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_ext_file_threshold(ref uint bytes) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_ext_file_threshold(swigCPtr, ref bytes);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_ext_file_threshold(uint bytes, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_ext_file_threshold(swigCPtr, bytes, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_feedback(BDB_DbFeedbackDelegate callback) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_feedback(swigCPtr, callback);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_flags(ref uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_flags(swigCPtr, ref flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_flags(uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_flags(swigCPtr, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_heapsize(ref uint gbytes, ref uint bytes) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_heapsize(swigCPtr, ref gbytes, ref bytes);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_heapsize(uint gbytes, uint bytes) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_heapsize(swigCPtr, gbytes, bytes);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_heap_regionsize(ref uint npages) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_heap_regionsize(swigCPtr, ref npages);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_heap_regionsize(uint npages) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_heap_regionsize(swigCPtr, npages);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_h_compare(BDB_CompareDelegate callback) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_h_compare(swigCPtr, callback);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_h_ffactor(ref uint ffactor) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_h_ffactor(swigCPtr, ref ffactor);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_h_ffactor(uint ffactor) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_h_ffactor(swigCPtr, ffactor);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_h_hash(BDB_HashDelegate callback) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_h_hash(swigCPtr, callback);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_h_nelem(ref uint nelem) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_h_nelem(swigCPtr, ref nelem);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_h_nelem(uint nelem) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_h_nelem(swigCPtr, nelem);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_lk_exclusive(ref int onoff, ref int nowait) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_lk_exclusive(swigCPtr, ref onoff, ref nowait);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_lk_exclusive(int nowait) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_lk_exclusive(swigCPtr, nowait);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_lorder(ref int lorder) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_lorder(swigCPtr, ref lorder);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_lorder(int lorder) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_lorder(swigCPtr, lorder);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_pagesize(ref uint pgsz) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_pagesize(swigCPtr, ref pgsz);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_pagesize(uint pgsz) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_pagesize(swigCPtr, pgsz);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal void set_msgcall(BDB_MsgcallDelegate db_msgcall_fcn) {
    libdb_csharpPINVOKE.DB_set_msgcall(swigCPtr, db_msgcall_fcn);
  }

  internal int set_msgfile(string msgfile) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_msgfile(swigCPtr, msgfile);
		DatabaseException.ThrowException(ret);
		return ret;
}

  private DatabaseEntry[] get_partition_keys(ref uint countp, ref uint sizep, ref int err) {
	IntPtr cPtr = libdb_csharpPINVOKE.DB_get_partition_keys(swigCPtr, ref countp, ref sizep, ref err);
	if (cPtr == IntPtr.Zero)
		return null;

	DatabaseEntry[] ret = new DatabaseEntry[countp - 1];
	IntPtr val;
	for (int i = 0; i < (countp - 1); i++) {
		val = new IntPtr((IntPtr.Size == 4 ? cPtr.ToInt32() : cPtr.ToInt64()) + i * sizep);
		ret[i] = DatabaseEntry.fromDBT(new DBT(val, false));
	}
	return ret; 
}

  internal int get_partition_parts(ref uint parts) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_partition_parts(swigCPtr, ref parts);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_partition(uint parts, IntPtr[] keys, BDB_PartitionDelegate partition) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_partition(swigCPtr, parts, keys, partition);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_priority(ref uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_priority(swigCPtr, ref flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_priority(uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_priority(swigCPtr, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_q_extentsize(ref uint extentsz) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_q_extentsize(swigCPtr, ref extentsz);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_q_extentsize(uint extentsz) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_q_extentsize(swigCPtr, extentsz);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_re_delim(ref int delim) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_re_delim(swigCPtr, ref delim);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_re_delim(int delim) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_re_delim(swigCPtr, delim);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_re_len(ref uint len) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_re_len(swigCPtr, ref len);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_re_len(uint len) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_re_len(swigCPtr, len);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_re_pad(ref int pad) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_re_pad(swigCPtr, ref pad);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_re_pad(int pad) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_re_pad(swigCPtr, pad);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int get_re_source(out IntPtr source) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_get_re_source(swigCPtr, out source);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int set_re_source(string source) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_set_re_source(swigCPtr, source);
		DatabaseException.ThrowException(ret);
		return ret;
}

  private IntPtr stat(DB_TXN txnid, uint flags, ref int err) {
	return libdb_csharpPINVOKE.DB_stat(swigCPtr, DB_TXN.getCPtr(txnid), flags, ref err);
}

  internal int stat_print(uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_stat_print(swigCPtr, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int sync(uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_sync(swigCPtr, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int truncate(DB_TXN txn, ref uint countp, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_truncate(swigCPtr, DB_TXN.getCPtr(txn), ref countp, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int upgrade(string file, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_upgrade(swigCPtr, file, flags);
		DatabaseException.ThrowException(ret);
		return ret;
}

  internal int verify(string file, string database, System.IO.TextWriter handle, BDB_FileWriteDelegate callback, uint flags) {
		int ret;
		ret = libdb_csharpPINVOKE.DB_verify(swigCPtr, file, database, handle, callback, flags);
		/* Verify is a db handle destructor.  Reflect that in the wrapper class. */
		swigCMemOwn = false;
		swigCPtr = new HandleRef(null, IntPtr.Zero);
		DatabaseException.ThrowException(ret);
		return ret;
}

}

}
