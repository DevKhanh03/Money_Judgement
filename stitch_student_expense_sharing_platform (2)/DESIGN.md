---
name: Student Living Shared Finance System
colors:
  surface: '#faf8ff'
  surface-dim: '#d2d9f4'
  surface-bright: '#faf8ff'
  surface-container-lowest: '#ffffff'
  surface-container-low: '#f2f3ff'
  surface-container: '#eaedff'
  surface-container-high: '#e2e7ff'
  surface-container-highest: '#dae2fd'
  on-surface: '#131b2e'
  on-surface-variant: '#3e4947'
  inverse-surface: '#283044'
  inverse-on-surface: '#eef0ff'
  outline: '#6e7977'
  outline-variant: '#bdc9c6'
  surface-tint: '#006a63'
  primary: '#005c55'
  on-primary: '#ffffff'
  primary-container: '#0f766e'
  on-primary-container: '#a3faef'
  inverse-primary: '#80d5cb'
  secondary: '#4b41e1'
  on-secondary: '#ffffff'
  secondary-container: '#645efb'
  on-secondary-container: '#fffbff'
  tertiary: '#734700'
  on-tertiary: '#ffffff'
  tertiary-container: '#945d00'
  on-tertiary-container: '#ffe6cc'
  error: '#ba1a1a'
  on-error: '#ffffff'
  error-container: '#ffdad6'
  on-error-container: '#93000a'
  primary-fixed: '#9cf2e8'
  primary-fixed-dim: '#80d5cb'
  on-primary-fixed: '#00201d'
  on-primary-fixed-variant: '#00504a'
  secondary-fixed: '#e2dfff'
  secondary-fixed-dim: '#c3c0ff'
  on-secondary-fixed: '#0f0069'
  on-secondary-fixed-variant: '#3323cc'
  tertiary-fixed: '#ffddb8'
  tertiary-fixed-dim: '#ffb95f'
  on-tertiary-fixed: '#2a1700'
  on-tertiary-fixed-variant: '#653e00'
  background: '#faf8ff'
  on-background: '#131b2e'
  surface-variant: '#dae2fd'
typography:
  display-lg:
    fontFamily: Be Vietnam Pro
    fontSize: 36px
    fontWeight: '700'
    lineHeight: 44px
    letterSpacing: -0.02em
  display-lg-mobile:
    fontFamily: Be Vietnam Pro
    fontSize: 28px
    fontWeight: '700'
    lineHeight: 36px
    letterSpacing: -0.01em
  headline-lg:
    fontFamily: Be Vietnam Pro
    fontSize: 28px
    fontWeight: '600'
    lineHeight: 36px
    letterSpacing: -0.01em
  headline-lg-mobile:
    fontFamily: Be Vietnam Pro
    fontSize: 22px
    fontWeight: '600'
    lineHeight: 28px
    letterSpacing: 0em
  headline-md:
    fontFamily: Be Vietnam Pro
    fontSize: 20px
    fontWeight: '600'
    lineHeight: 28px
    letterSpacing: -0.005em
  headline-sm:
    fontFamily: Be Vietnam Pro
    fontSize: 16px
    fontWeight: '600'
    lineHeight: 24px
    letterSpacing: 0em
  body-lg:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '400'
    lineHeight: 24px
    letterSpacing: 0em
  body-md:
    fontFamily: Inter
    fontSize: 14px
    fontWeight: '400'
    lineHeight: 20px
    letterSpacing: 0em
  body-sm:
    fontFamily: Inter
    fontSize: 12px
    fontWeight: '400'
    lineHeight: 16px
    letterSpacing: 0.01em
  numeric-lg:
    fontFamily: Inter
    fontSize: 24px
    fontWeight: '700'
    lineHeight: 32px
    letterSpacing: -0.01em
  numeric-md:
    fontFamily: Inter
    fontSize: 16px
    fontWeight: '600'
    lineHeight: 24px
    letterSpacing: -0.005em
  label-md:
    fontFamily: Inter
    fontSize: 13px
    fontWeight: '500'
    lineHeight: 18px
    letterSpacing: 0.01em
  label-sm:
    fontFamily: Inter
    fontSize: 11px
    fontWeight: '600'
    lineHeight: 14px
    letterSpacing: 0.04em
rounded:
  sm: 0.25rem
  DEFAULT: 0.5rem
  md: 0.75rem
  lg: 1rem
  xl: 1.5rem
  full: 9999px
spacing:
  gutter: 1.5rem
  gutter-sm: 1rem
  margin: 2rem
  margin-sm: 1rem
  space-xs: 0.25rem
  space-sm: 0.5rem
  space-md: 1rem
  space-lg: 1.5rem
  space-xl: 2rem
  space-2xl: 3rem
---

## Brand & Style

This design system defines a streamlined, transparent, and approachable financial management interface tailored for communal student living. It resolves the interpersonal frictions of shared dorm expenses, utility bills, and multi-party debt settlement by replacing informal notebooks and group chats with systematic, clear-cut financial records.

The personality balances student approachability with financial rigor:
- **Trustworthy & Transparent:** Financial interactions are balanced, mathematically unambiguous, and neutral to preserve roommates' relationships.
- **Efficient & Purposeful:** Designed for rapid bill input, split-payment distribution, and instant balance verification between lectures.
- **Culturally Attuned:** Tailored specifically for Vietnamese diacritics, Vietnamese đồng currency formatting (₫ / VNĐ), and local split mechanisms (per capita, meter-reading differentials, rotating duty).

The design movement combines **Modern Corporate Precision** with **Tactile Functional Utility**. Crisp surface boundaries, soft atmospheric shadows, balanced teal surfaces, and high-legibility typography provide a dependable structure free of distracting decorative fluff.

## Colors

The color palette establishes immediate financial clarity, using deep teal as the anchor of shared solvency and trust, accompanied by structural slate neutrals and distinct transactional semantic colors.

### Palette Roles
- **Primary Teal (`#0F766E`):** Represents shared resources, total room balance, primary navigation landmarks, and committed positive actions (record expense, approve transfer).
- **Secondary Indigo (`#4F46E5`):** Denotes automated calculations, scheduled monthly bills (rent, fixed Wi-Fi), and member-specific split distributions.
- **Tertiary Amber (`#F59E0B`):** Highlights pending approvals, unsettled debts, unconfirmed roommate transfers, and reminder queues.
- **Semantic Red / Coral (`#EF4444`):** Indicates overdue rent, negative roommate balance (debtor), and destructive actions.
- **Semantic Green / Emerald (`#10B981`):** Represents cleared payments, fully settled balances, and verified bank receipts.
- **Neutral Foundations (`#0F172A` to `#F8FAFC`):** Slate-tinted neutrals eliminate sterile greys, keeping tables readable across long budgeting sessions.

### Application Rules
- **Color Surface Ratios:** Backgrounds remain light (`#F8FAFC` canvas, `#FFFFFF` cards). High-chroma teal is reserved for primary CTAs, active states, and focal metrics.
- **Financial Status Tagging:** Status badges combine a 10% tint background with a full-contrast text label (e.g., pending debt uses amber-50 background with amber-800 text) to guarantee WCAG AAA compliance.
- **Currency Numbers:** Negative debt values (`-350.000 ₫`) use coral, positive receivables (`+150.000 ₫`) use emerald, and gross room expenses default to primary slate (`#0F172A`).

## Typography

Typography prioritizes diacritic legibility for Vietnamese text alongside strict tabular data alignment for student financial tables.

### Type Pairing
- **Be Vietnam Pro (Headlines & Display):** Engineered natively for Vietnamese tones, accent marks, and ligatures. It ensures acute (`sắc`), grave (`huyền`), hook (`hỏi`), tilde (`ngã`), and dot below (`nặng`) glyphs avoid clipping or overlapping with ascenders and descenders.
- **Inter (Body, Financial Metrics & Controls):** Provides neutral, utilitarian stability. It offers robust tabular numeric figures (`font-variant-numeric: tabular-nums; tnum`) essential for aligning decimal-free Vietnamese đồng values across ledgers and debt split summaries.

### Typographic Rules
- **Vietnamese Diacritics Protection:** Minimum line-height is locked to 1.35x on all headline levels to prevent tone mark truncation when nested inside tight card headers.
- **Currency Standard:** All amounts must append the standard `₫` or `VNĐ` unit token separated by a non-breaking space (e.g., `1.450.000 ₫`). Grouping separators must strictly use periods (`.`), following Vietnamese financial convention.
- **Labels & Microcopy:** System labels (e.g., `ĐÃ THANH TOÁN`, `CHƯA CHIA`) are rendered in `label-sm` with upper-case tracking to maintain legibility in compact tags.

## Layout & Spacing

The layout is built on an 8pt spatial cadence designed around desktop analytical operations, adapting seamlessly to mobile devices when students record rapid on-the-go expenses.

### Layout Model
- **Desktop (>= 1024px):** Fixed 260px persistent sidebar for navigation between dorm rooms, monthly ledgers, and debt matrices. Main content spans a 12-column fluid grid with `1.5rem` (`24px`) gutters and a max canvas width of `1440px`.
- **Tablet (768px - 1023px):** Sidebar compresses into a 72px icon-rail. The grid collapses to 8 columns with `1rem` (`16px`) gutters.
- **Mobile (< 768px):** Single-column flow with persistent bottom navigation bar. Outer canvas margin shrinks to `1rem` (`16px`). Multi-column split tables reflow into discrete transaction cards.

### Spacing Rhythm
- **Internal Component Padding:** Buttons, inputs, and list rows maintain compact vertical padding (`space-sm` to `space-md`) to ensure dense display of expense logs without vertical scroll fatigue.
- **Card Spacing:** Dashboard summary metrics use `space-lg` (`24px`) internal padding, while nested sub-items (roommate split lists) use `space-md` (`16px`).
- **Section Stack:** Major sections (e.g., "Chi phí chưa quyết toán" and "Lịch sử đóng tiền") maintain `space-xl` (`32px`) margin between block elements.

## Elevation & Depth

This system avoids heavy, skeuomorphic drop-shadows in favor of **Tonal Layers with Subtle Ambient Occlusion**. This approach keeps financial data calm, flat, and legible while maintaining physical clarity between interactive dialogs, cards, and canvas surfaces.

### Elevation Levels
- **Level 0 (Canvas Base):** Background default `#F8FAFC`. Completely flat; non-interactive backdrop.
- **Level 1 (Surface Cards & Tables):** Pure white `#FFFFFF` surface paired with a subtle, slate-tinted border (`1px solid #E2E8F0`) and an ambient shadow: `0 1px 3px 0 rgba(15, 23, 42, 0.04), 0 1px 2px -1px rgba(15, 23, 42, 0.04)`. Used for expense summary widgets, bill logs, and roommate profiles.
- **Level 2 (Hover & Active Drag):** Raised interactive state for clickable transaction rows and action cards: `0 4px 6px -1px rgba(15, 23, 42, 0.07), 0 2px 4px -2px rgba(15, 23, 42, 0.05)`. Border shifts to `#CBD5E1`.
- **Level 3 (Dropdowns & Popovers):** Date range selectors, split-type selectors, and filter flyouts: `0 10px 15px -3px rgba(15, 23, 42, 0.08), 0 4px 6px -4px rgba(15, 23, 42, 0.04)`.
- **Level 4 (Modals & Settlement Overlays):** New expense entry sheets, payment confirmation dialogs, and debt reconciliation modals: `0 20px 25px -5px rgba(15, 23, 42, 0.12), 0 8px 10px -6px rgba(15, 23, 42, 0.06)`, framed over a 40% opacity slate backdrop (`rgba(15, 23, 42, 0.40)`).

## Shapes

The design system implements a **Rounded (Level 2)** shape standard. This level creates a friendly, contemporary aesthetic suited for young adults while remaining crisp and structured enough for structured ledger grids.

### Corner Radius Mapping
- **Base Components (`0.5rem` / `8px`):** Standard input fields, search bars, action buttons, table filters, select boxes, and alert banners.
- **Container Surfaces (`1rem` / `16px`):** Overview metric cards, monthly summary modules, transaction list wrappers, and modal windows.
- **Nested Inner Surfaces (`0.375rem` / `6px`):** Sub-elements within cards, such as individual roommate payment progress bars and nested bill attachments.
- **Full Pill (`9999px`):** Transaction status tags (`Đã thanh toán`, `Chờ duyệt`), avatar initials, and filter chips.

## Components

### Buttons
- **Primary:** Background `#0F766E`, text `#FFFFFF`, border-radius `0.5rem`, font `Inter` weight 600. Hover: `#115E59`. Active: `#134E4A`. Used for critical calls to action: "Tạo khoản chi", "Xác nhận trả tiền".
- **Secondary:** Surface `#FFFFFF`, border `1px solid #CBD5E1`, text `#334155`. Hover: `#F1F5F9`. Used for filters, invoice export ("Xuất file"), and cancellation actions.
- **Subtle / Ghost:** Transparent surface, text `#0F766E`. Hover: `#F0FDFA`. Used for inline table actions: "Chi tiết", "Sửa".
- **Destructive:** Surface `#FEF2F2`, text `#DC2626`, border `1px solid #FCA5A5`. Hover: `#DC2626`, text `#FFFFFF`.

### Chips & Badges
- **Status Tags (Pill-shaped, `9999px`):**
  - *Completed (Đã trả):* Background `#ECFDF5`, text `#065F46`, left-aligned 6px emerald dot.
  - *Pending (Chờ thanh toán):* Background `#FFFBEB`, text `#92400E`, left-aligned 6px amber dot.
  - *Overdue / Debt (Nợ quá hạn):* Background `#FEF2F2`, text `#991B1B`, left-aligned 6px red dot.
- **Split-Type Chips:** Background `#EEF2FF`, text `#3730A3`, border `1px solid #C7D2FE`. Indicates division method: "Chia đều" (Equal), "Theo người" (Per Capita), or "Theo chỉ số điện" (Meter Based).

### Data Tables & Ledgers
- **Header:** Background `#F8FAFC`, text `label-sm` in slate-500, uppercase, bottom border `1px solid #E2E8F0`. Tabular column headers include Date ("Ngày"), Item ("Khoản chi"), Payer ("Người trả"), Split ("Phân chia"), and Amount ("Số tiền").
- **Row:** Height `52px`, alternating row hover `#F8FAFC`. Financial amounts must strictly align right with `numeric-md` font.
- **Total/Summary Row:** Grounded with a top double border or bold `2px solid #CBD5E1`, background `#F1F5F9`.

### Input Fields & Forms
- **Text & Currency Inputs:** Height `42px`, padding `0 12px`, border `1px solid #CBD5E1`, background `#FFFFFF`, text `body-md`. Focus state uses `#0F766E` outline with `0 0 0 3px rgba(15, 118, 110, 0.15)`.
- **Currency Field Prefix/Suffix:** Suffix "₫" is anchored inside the input container in static `label-md` neutral grey.
- **Checkboxes & Radios:** Size `18px`, corner radius `4px` (checkboxes) and `9999px` (radios). Primary teal fill `#0F766E` when active. Used for selecting which roommates are included in a shared split.

### Cards & Metrics (Thẻ thống kê)
- **Financial Metric Card:** Level 1 elevation, `1rem` radius. Displays primary metric (`numeric-lg`) on top, metric title (`body-sm` in `#64748B`) below, and a micro-status pill indicating net status ("Bạn còn nợ", "Bạn được nhận").
- **Roommate Balance Matrix Card:** Displays each student's profile photo/avatar, room number, current balance, and quick settlement action button ("Thanh toán ngay").