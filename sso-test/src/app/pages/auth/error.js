import { useRouter } from "next/router";

export default function ErrorPage() {
  const router = useRouter();
  const { error } = router.query;

  let errorMessage = "";
  switch (error) {
    case "OAuthAccountNotLinked":
      errorMessage = "Tài khoản Google chưa được liên kết.";
      break;
    case "OAuthCallback":
      errorMessage = "Lỗi callback OAuth.";
      break;
    default:
      errorMessage = "Đã xảy ra lỗi khi xác thực.";
  }

  return (
    <div>
      <h1>Đã xảy ra lỗi</h1>
      <p>{errorMessage}</p>
    </div>
  );
}
