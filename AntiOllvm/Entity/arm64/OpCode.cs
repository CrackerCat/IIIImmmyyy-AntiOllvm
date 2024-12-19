﻿namespace AntiOllvm.entity;

public enum OpCode
{
    NONE,
    MOV,
    MOVK,
    CMP,
    B_LT,
    B_LE,
    B_GT,
    B_EQ,
    B_NE,
    BL,
    B,
    SUB,
    ADD,
    LDUR,
    STR,
    STP,
    LDR,
    STUR,
    MRS,
    SXTW,
    CSEL,
    LDRSW,
    LDRB,
    EOR,
    STRB,
    MSUB,
    RET,
    LDP,
    ADRP,
    ADRL,
    CBZ,
    STRH,
    FCMP,
    AND,
    DUP,
    MOVI,
    SDIV,
    NOP,
    CMN,
    SUBS,
}