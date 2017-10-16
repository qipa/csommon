// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: ActivityStormV1Data.proto

#ifndef PROTOBUF_ActivityStormV1Data_2eproto__INCLUDED
#define PROTOBUF_ActivityStormV1Data_2eproto__INCLUDED

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
class ActivityStormActivityStormV1;
class ActivityStormActivityStormV1DefaultTypeInternal;
extern ActivityStormActivityStormV1DefaultTypeInternal _ActivityStormActivityStormV1_default_instance_;

namespace protobuf_ActivityStormV1Data_2eproto {
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
}  // namespace protobuf_ActivityStormV1Data_2eproto

// ===================================================================

class ActivityStormActivityStormV1 : public ::google::protobuf::Message /* @@protoc_insertion_point(class_definition:ActivityStormActivityStormV1) */ {
 public:
  ActivityStormActivityStormV1();
  virtual ~ActivityStormActivityStormV1();

  ActivityStormActivityStormV1(const ActivityStormActivityStormV1& from);

  inline ActivityStormActivityStormV1& operator=(const ActivityStormActivityStormV1& from) {
    CopyFrom(from);
    return *this;
  }
  #if LANG_CXX11
  ActivityStormActivityStormV1(ActivityStormActivityStormV1&& from) noexcept
    : ActivityStormActivityStormV1() {
    *this = ::std::move(from);
  }

  inline ActivityStormActivityStormV1& operator=(ActivityStormActivityStormV1&& from) noexcept {
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
  static const ActivityStormActivityStormV1& default_instance();

  static inline const ActivityStormActivityStormV1* internal_default_instance() {
    return reinterpret_cast<const ActivityStormActivityStormV1*>(
               &_ActivityStormActivityStormV1_default_instance_);
  }
  static PROTOBUF_CONSTEXPR int const kIndexInFileMessages =
    0;

  void Swap(ActivityStormActivityStormV1* other);
  friend void swap(ActivityStormActivityStormV1& a, ActivityStormActivityStormV1& b) {
    a.Swap(&b);
  }

  // implements Message ----------------------------------------------

  inline ActivityStormActivityStormV1* New() const PROTOBUF_FINAL { return New(NULL); }

  ActivityStormActivityStormV1* New(::google::protobuf::Arena* arena) const PROTOBUF_FINAL;
  void CopyFrom(const ::google::protobuf::Message& from) PROTOBUF_FINAL;
  void MergeFrom(const ::google::protobuf::Message& from) PROTOBUF_FINAL;
  void CopyFrom(const ActivityStormActivityStormV1& from);
  void MergeFrom(const ActivityStormActivityStormV1& from);
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
  void InternalSwap(ActivityStormActivityStormV1* other);
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

  // optional sint32 Type = 1 [default = -1];
  bool has_type() const;
  void clear_type();
  static const int kTypeFieldNumber = 1;
  ::google::protobuf::int32 type() const;
  void set_type(::google::protobuf::int32 value);

  // optional sint32 Time = 2 [default = -1];
  bool has_time() const;
  void clear_time();
  static const int kTimeFieldNumber = 2;
  ::google::protobuf::int32 time() const;
  void set_time(::google::protobuf::int32 value);

  // optional sint32 ActID = 3 [default = -1];
  bool has_actid() const;
  void clear_actid();
  static const int kActIDFieldNumber = 3;
  ::google::protobuf::int32 actid() const;
  void set_actid(::google::protobuf::int32 value);

  // optional sint32 LvD = 4 [default = -1];
  bool has_lvd() const;
  void clear_lvd();
  static const int kLvDFieldNumber = 4;
  ::google::protobuf::int32 lvd() const;
  void set_lvd(::google::protobuf::int32 value);

  // @@protoc_insertion_point(class_scope:ActivityStormActivityStormV1)
 private:
  void set_has_type();
  void clear_has_type();
  void set_has_time();
  void clear_has_time();
  void set_has_actid();
  void clear_has_actid();
  void set_has_lvd();
  void clear_has_lvd();

  ::google::protobuf::internal::InternalMetadataWithArena _internal_metadata_;
  ::google::protobuf::internal::HasBits<1> _has_bits_;
  mutable int _cached_size_;
  ::google::protobuf::int32 type_;
  ::google::protobuf::int32 time_;
  ::google::protobuf::int32 actid_;
  ::google::protobuf::int32 lvd_;
  friend struct protobuf_ActivityStormV1Data_2eproto::TableStruct;
};
// ===================================================================


// ===================================================================

#if !PROTOBUF_INLINE_NOT_IN_HEADERS
#ifdef __GNUC__
  #pragma GCC diagnostic push
  #pragma GCC diagnostic ignored "-Wstrict-aliasing"
#endif  // __GNUC__
// ActivityStormActivityStormV1

// optional sint32 Type = 1 [default = -1];
inline bool ActivityStormActivityStormV1::has_type() const {
  return (_has_bits_[0] & 0x00000001u) != 0;
}
inline void ActivityStormActivityStormV1::set_has_type() {
  _has_bits_[0] |= 0x00000001u;
}
inline void ActivityStormActivityStormV1::clear_has_type() {
  _has_bits_[0] &= ~0x00000001u;
}
inline void ActivityStormActivityStormV1::clear_type() {
  type_ = -1;
  clear_has_type();
}
inline ::google::protobuf::int32 ActivityStormActivityStormV1::type() const {
  // @@protoc_insertion_point(field_get:ActivityStormActivityStormV1.Type)
  return type_;
}
inline void ActivityStormActivityStormV1::set_type(::google::protobuf::int32 value) {
  set_has_type();
  type_ = value;
  // @@protoc_insertion_point(field_set:ActivityStormActivityStormV1.Type)
}

// optional sint32 Time = 2 [default = -1];
inline bool ActivityStormActivityStormV1::has_time() const {
  return (_has_bits_[0] & 0x00000002u) != 0;
}
inline void ActivityStormActivityStormV1::set_has_time() {
  _has_bits_[0] |= 0x00000002u;
}
inline void ActivityStormActivityStormV1::clear_has_time() {
  _has_bits_[0] &= ~0x00000002u;
}
inline void ActivityStormActivityStormV1::clear_time() {
  time_ = -1;
  clear_has_time();
}
inline ::google::protobuf::int32 ActivityStormActivityStormV1::time() const {
  // @@protoc_insertion_point(field_get:ActivityStormActivityStormV1.Time)
  return time_;
}
inline void ActivityStormActivityStormV1::set_time(::google::protobuf::int32 value) {
  set_has_time();
  time_ = value;
  // @@protoc_insertion_point(field_set:ActivityStormActivityStormV1.Time)
}

// optional sint32 ActID = 3 [default = -1];
inline bool ActivityStormActivityStormV1::has_actid() const {
  return (_has_bits_[0] & 0x00000004u) != 0;
}
inline void ActivityStormActivityStormV1::set_has_actid() {
  _has_bits_[0] |= 0x00000004u;
}
inline void ActivityStormActivityStormV1::clear_has_actid() {
  _has_bits_[0] &= ~0x00000004u;
}
inline void ActivityStormActivityStormV1::clear_actid() {
  actid_ = -1;
  clear_has_actid();
}
inline ::google::protobuf::int32 ActivityStormActivityStormV1::actid() const {
  // @@protoc_insertion_point(field_get:ActivityStormActivityStormV1.ActID)
  return actid_;
}
inline void ActivityStormActivityStormV1::set_actid(::google::protobuf::int32 value) {
  set_has_actid();
  actid_ = value;
  // @@protoc_insertion_point(field_set:ActivityStormActivityStormV1.ActID)
}

// optional sint32 LvD = 4 [default = -1];
inline bool ActivityStormActivityStormV1::has_lvd() const {
  return (_has_bits_[0] & 0x00000008u) != 0;
}
inline void ActivityStormActivityStormV1::set_has_lvd() {
  _has_bits_[0] |= 0x00000008u;
}
inline void ActivityStormActivityStormV1::clear_has_lvd() {
  _has_bits_[0] &= ~0x00000008u;
}
inline void ActivityStormActivityStormV1::clear_lvd() {
  lvd_ = -1;
  clear_has_lvd();
}
inline ::google::protobuf::int32 ActivityStormActivityStormV1::lvd() const {
  // @@protoc_insertion_point(field_get:ActivityStormActivityStormV1.LvD)
  return lvd_;
}
inline void ActivityStormActivityStormV1::set_lvd(::google::protobuf::int32 value) {
  set_has_lvd();
  lvd_ = value;
  // @@protoc_insertion_point(field_set:ActivityStormActivityStormV1.LvD)
}

#ifdef __GNUC__
  #pragma GCC diagnostic pop
#endif  // __GNUC__
#endif  // !PROTOBUF_INLINE_NOT_IN_HEADERS

// @@protoc_insertion_point(namespace_scope)


// @@protoc_insertion_point(global_scope)

#endif  // PROTOBUF_ActivityStormV1Data_2eproto__INCLUDED