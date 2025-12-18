# Adapter Design Pattern 🔌

## Overview
The **Adapter Design Pattern** allows two incompatible classes or systems to work together without changing their existing code.

It acts as a **translator** between the new system and the old (legacy) system.

---

## Simple Explanation (From Zero)
Sometimes, a system expects data or behavior in a specific format, but an existing (old) class provides it in a different way.

Instead of modifying the old class, we create an **Adapter** that converts the request from one format to another.

---

## Real-Life Example 🌍
- A person speaks **Arabic**
- The system understands **English**
- They cannot communicate directly ❌
- A **translator (Adapter)** converts Arabic to English ✔

---

## Pattern Type
**Structural Design Pattern**

---

## Problem
- The new system understands **English only**
- The old (legacy) system speaks **Arabic**
- Their interfaces are incompatible

---

## Solution
Create an **Adapter** that:
- Implements the interface expected by the new system
- Internally uses the old system
- Translates the request between them

---
📘 Detailed Explanation (Notion)

For a step-by-step explanation with simple examples and diagrams, check the Notion page:

🔗 [View detailed explanation on Notion](https://www.notion.so/Adapter-Design-Pattern-2cd5b020cd9a80c78708ecc2f3aea7c3?source=copy_link)

