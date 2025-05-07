$TTL 1h
@      IN  SOA  linux01.ayu.cs. admin.ayu.cs. (
          2025050701   ; Serial YYYYMMDDnn
          12h          ; Refresh
          15m          ; Retry
          4w           ; Expire
          1h )         ; Negative Cache TTL

@      IN  NS   linux01.ayu.cs.

; ---- A 레코드 ----
linux01     IN  A    220.66.60.102
linux02     IN  A    220.66.60.103
; 서비스 예시
