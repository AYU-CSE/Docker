FROM internetsystemsconsortium/bind9:9.18

# 설정 복사
COPY config/ /etc/bind/
COPY zones/  /etc/bind/zones/

RUN chown -R bind:bind /etc/bind && chmod 640 /etc/bind/zones/*

# **CMD 또는 ENTRYPOINT 절을 넣지 않는다!**
# (이미지 기본 ENTRYPOINT 그대로 사용)
