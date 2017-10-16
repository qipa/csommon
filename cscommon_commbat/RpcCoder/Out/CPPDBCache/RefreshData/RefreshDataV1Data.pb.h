// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RefreshDataV1Data.proto

#ifndef PROTOBUF_RefreshDataV1Data_2eproto__INCLUDED
#define PROTOBUF_RefreshDataV1Data_2eproto__INCLUDED

#include <string>

#include <google/protobuf/stubs/common.h>

#if GOOGLE_PROTOBUF_VERSION < 3004000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please update
#error your headers.
#endif
#if 3004000 < GOOGLE_PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers.  Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/io/coded_stream.h>
#include <google/protobuf/arena.h>
#include <google/protobuf/arenastring.h>
#include <google/protobuf/generated_message_table_driven.h>
#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/metadata.h>
#include <google/protobuf/message.h>
#include <google/protobuf/repeated_field.h>  // IWYU pragma: export
#include <google/protobuf/extension_set.h>  // IWYU pragma: export
#include <google/protobuf/unknown_field_set.h>
#include "PublicStruct.pb.h"
// @@protoc_insertion_point(includes)
class RefreshDataRefreshDataV1;
class RefreshDataRefreshDataV1DefaultTypeInternal;
extern RefreshDataRefreshDataV1DefaultTypeInternal _RefreshDataRefreshDataV1_default_instance_;

namespace protobuf_RefreshDataV1Data_2eproto {
// Internal implementation detail -- do not call these.
struct TableStruct {
  static const ::google::protobuf::internal::ParseTableField entries[];
  static const ::google::protobuf::internal::AuxillaryParseTableField aux[];
  static const ::google::protobuf::internal::ParseTable schema[];
  static const ::google::protobuf::uint32 offsets[];
  static const ::google::protobuf::internal::FieldMetadata field_metadata[];
  static const ::google::protobuf::internal::SerializationTable serialization_table[];
  static void InitDefaultsImpl();
};
void AddDescriptors();
void InitDefaults();
}  // namespace protobuf_RefreshDataV1Data_2eproto

// ===================================================================

class RefreshDataRefreshDataV1 : public ::google::protobuf::Message /* @@protoc_insertion_point(class_definition:RefreshDataRefreshDataV1) */ {
 public:
  RefreshDataRefreshDataV1();
  virtual ~RefreshDataRefreshDataV1();

  RefreshDataRefreshDataV1(const RefreshDataRefreshDataV1& from);

  inline RefreshDataRefreshDataV1& operator=(const RefreshDataRefreshDataV1& from) {
    CopyFrom(from);
    return *this;
  }
  #if LANG_CXX11
  RefreshDataRefreshDataV1(RefreshDataRefreshDataV1&& from) noexcept
    : RefreshDataRefreshDataV1() {
    *this = ::std::move(from);
  }

  inline RefreshDataRefreshDataV1& operator=(RefreshDataRefreshDataV1&& from) noexcept {
    if (GetArenaNoVirtual() == from.GetArenaNoVirtual()) {
      if (this != &from) InternalSwap(&from);
    } else {
      CopyFrom(from);
    }
    return *this;
  }
  #endif
  inline const ::google::protobuf::UnknownFieldSet& unknown_fields() const {
    return _internal_metadata_.unknown_fields();
  }
  inline ::google::protobuf::UnknownFieldSet* mutable_unknown_fields() {
    return _internal_metadata_.mutable_unknown_fields();
  }

  static const ::google::protobuf::Descriptor* descriptor();
  static const RefreshDataRefreshDataV1& default_instance();

  static inline const RefreshDataRefreshDataV1* internal_default_instance() {
    return reinterpret_cast<const RefreshDataRefreshDataV1*>(
               &_RefreshDataRefreshDataV1_default_instance_);
  }
  static PROTOBUF_CONSTEXPR int const kIndexInFileMessages =
    0;

  void Swap(RefreshDataRefreshDataV1* other);
  friend void swap(RefreshDataRefreshDataV1& a, RefreshDataRefreshDataV1& b) {
    a.Swap(&b);
  }

  // implements Message ----------------------------------------------

  inline RefreshDataRefreshDataV1* New() const PROTOBUF_FINAL { return New(NULL); }

  RefreshDataRefreshDataV1* New(::google::protobuf::Arena* arena) const PROTOBUF_FINAL;
  void CopyFrom(const ::google::protobuf::Message& from) PROTOBUF_FINAL;
  void MergeFrom(const ::google::protobuf::Message& from) PROTOBUF_FINAL;
  void CopyFrom(const RefreshDataRefreshDataV1& from);
  void MergeFrom(const RefreshDataRefreshDataV1& from);
  void Clear() PROTOBUF_FINAL;
  bool IsInitialized() const PROTOBUF_FINAL;

  size_t ByteSizeLong() const PROTOBUF_FINAL;
  bool MergePartialFromCodedStream(
      ::google::protobuf::io::CodedInputStream* input) PROTOBUF_FINAL;
  void SerializeWithCachedSizes(
      ::google::protobuf::io::CodedOutputStream* output) const PROTOBUF_FINAL;
  ::google::protobuf::uint8* InternalSerializeWithCachedSizesToArray(
      bool deterministic, ::google::protobuf::uint8* target) const PROTOBUF_FINAL;
  int GetCachedSize() const PROTOBUF_FINAL { return _cached_size_; }
  private:
  void SharedCtor();
  void SharedDtor();
  void SetCachedSize(int size) const PROTOBUF_FINAL;
  void InternalSwap(RefreshDataRefreshDataV1* other);
  private:
  inline ::google::protobuf::Arena* GetArenaNoVirtual() const {
    return NULL;
  }
  inline void* MaybeArenaPtr() const {
    return NULL;
  }
  public:

  ::google::protobuf::Metadata GetMetadata() const PROTOBUF_FINAL;

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  // optional sint32 LastRefreshTime = 1 [default = 0];
  bool has_lastrefreshtime() const;
  void clear_lastrefreshtime();
  static const int kLastRefreshTimeFieldNumber = 1;
  ::google::protobuf::int32 lastrefreshtime() const;
  void set_lastrefreshtime(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:RefreshDataRefreshDataV1)
 private:
  void set_has_lastrefreshtime();
  void clear_has_lastrefreshtime();

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  ::google::protobuf::internal::HasBits<1> _has_bits_;
  mutable int _cached_size_;
  ::google::protobuf::int32 lastrefreshtime_;
  friend struct protobuf_RefreshDataV1Data_2eproto::TableStruct;
};
// ===================================================================


// ===================================================================

#if !PROTOBUF_INLINE_NOT_IN_HEADERS
#ifdef __GNUC__
  #pragma GCC diagnostic push
  #pragma GCC diagnostic ignored "-Wstrict-aliasing"
#endif  // __GNUC__
// RefreshDataRefreshDataV1

// optional sint32 LastRefreshTime = 1 [default = 0];
inline bool RefreshDataRefreshDataV1::has_lastrefreshtime() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void RefreshDataRefreshDataV1::set_has_lastrefreshtime() {
  _has_bits_[0] |= 0x00000001u;
}
inline void RefreshDataRefreshDataV1::clear_has_lastrefreshtime() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void RefreshDataRefreshDataV1::clear_lastrefreshtime() {
  lastrefreshtime_ = 0;
  clear_has_lastrefreshtime();
}
inline ::google::protobuf::int32 RefreshDataRefreshDataV1::lastrefreshtime() const {
  // @@protoc_insertion_point(field_get:RefreshDataRefreshDataV1.LastRefreshTime)
  return lastrefreshtime_;
}
inline void RefreshDataRefreshDataV1::set_lastrefreshtime(::google::protobuf::int32 value) {
  set_has_lastrefreshtime();
  lastrefreshtime_ = value;
  // @@protoc_insertion_point(field_set:RefreshDataRefreshDataV1.LastRefreshTime)
}

#ifdef __GNUC__
  #pragma GCC diagnostic pop
#endif  // __GNUC__
#endif  // !PROTOBUF_INLINE_NOT_IN_HEADERS

// @@protoc_insertion_point(namespace_scope)


// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_RefreshDataV1Data_2eproto__INCLUDED